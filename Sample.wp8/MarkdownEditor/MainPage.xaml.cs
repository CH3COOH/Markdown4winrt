using Microsoft.Phone.Controls;
using System.IO;
using System.IO.IsolatedStorage;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MarkdownEditor
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async Task SaveTextAsync(string text)
        {
            var store = IsolatedStorageFile.GetUserStoreForApplication();
            using (var strm = store.OpenFile("log.txt", FileMode.OpenOrCreate))
            using (var writer = new StreamWriter(strm))
            {
                await writer.WriteAsync(text);
            }
        }

        private async void pivot_SelectionChanged(object sender, 
            SelectionChangedEventArgs e)
        {
            var pivot = sender as Pivot;
            if (pivot == null)
            {
                return;
            }

            // 入力されているテキストを保存する
            await SaveTextAsync(editorArea.Text);

            // markdownからhtmlに変換してプレビューページに表示する
            var markdown = new MarkdownSharp.Markdown();
            var transHtml = markdown.Transform(editorArea.Text);
            previewArea.NavigateToString(transHtml);
        }
    }
}