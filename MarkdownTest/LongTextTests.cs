using MarkdownSharp;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;
using System.Threading.Tasks;
using Windows.Storage;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Storage.Streams;

namespace MarkdownTest
{
    [TestClass]
    public class LongTextTests
    {
        private Markdown m = new Markdown();

        async Task<string> ReadTextAsync(StorageFile file)
        {
#if NETFX_CORE
            var text = await FileIO.ReadTextAsync(file);
#else
            var text = default(string);
            using (var stream = await file.OpenReadAsync())
            {
                var size = stream.Size;
                using (var inputStream = stream.GetInputStreamAt(0))
                {
                    var dataReader = new DataReader(inputStream);
                    uint numBytesLoaded = await dataReader.LoadAsync((uint)size);
                    text = dataReader.ReadString(numBytesLoaded);
                }
            }
#endif
            return text;
        }


        [TestMethod]
        public async Task markdownExampleLong1()
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(
                new System.Uri("ms-appx:///benchmark/markdown-example-long-1.text"));
            var text = await ReadTextAsync(file);
            var html = m.Transform(text);
        }

        [TestMethod]
        public async Task markdownExampleLong2()
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(
                new System.Uri("ms-appx:///benchmark/markdown-example-long-2.text"));
            var text = await ReadTextAsync(file);
            var html = m.Transform(text);
        }

        [TestMethod]
        public async Task markdownExampleMedium1()
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(
                new System.Uri("ms-appx:///benchmark/markdown-example-medium-1.text"));
            var text = await ReadTextAsync(file);
            var html = m.Transform(text);
        }

        [TestMethod]
        public async Task markdownExampleMedium2()
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(
                new System.Uri("ms-appx:///benchmark/markdown-example-medium-2.text"));
            var text = await ReadTextAsync(file);
            var html = m.Transform(text);
        }

        [TestMethod]
        public async Task markdownExampleShort1()
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(
                new System.Uri("ms-appx:///benchmark/markdown-example-short-1.text"));
            var text = await ReadTextAsync(file);
            var html = m.Transform(text);
        }

        [TestMethod]
        public async Task markdownExampleShort2()
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(
                new System.Uri("ms-appx:///benchmark/markdown-example-short-2.text"));
            var text = await ReadTextAsync(file);
            var html = m.Transform(text);
        }

        [TestMethod]
        public async Task markdownReadme32()
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(
                new System.Uri("ms-appx:///benchmark/markdown-readme.32.text"));
            var text = await ReadTextAsync(file);
            var html = m.Transform(text);
        }

        [TestMethod]
        public async Task markdownReadme8()
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(
                new System.Uri("ms-appx:///benchmark/markdown-readme.8.text"));
            var text = await ReadTextAsync(file);
            var html = m.Transform(text);
        }

        [TestMethod]
        public async Task markdownReadme()
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(
                new System.Uri("ms-appx:///benchmark/markdown-readme.text"));
            var text = await ReadTextAsync(file);
            var html = m.Transform(text);
        }
    }
}
