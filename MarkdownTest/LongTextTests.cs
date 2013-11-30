using MarkdownSharp;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;
using System.Threading.Tasks;
using Windows.Storage;

namespace MarkdownTest
{
    [TestClass]
    public class LongTextTests
    {
        private Markdown m = new Markdown();

        [TestMethod]
        public async Task markdownExampleLong1()
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(
                new System.Uri("ms-appx:///benchmark/markdown-example-long-1.text"));
            var text = await FileIO.ReadTextAsync(file);
            var html = m.Transform(text);
        }

        [TestMethod]
        public async Task markdownExampleLong2()
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(
                new System.Uri("ms-appx:///benchmark/markdown-example-long-2.text"));
            var text = await FileIO.ReadTextAsync(file);
            var html = m.Transform(text);
        }

        [TestMethod]
        public async Task markdownExampleMedium1()
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(
                new System.Uri("ms-appx:///benchmark/markdown-example-medium-1.text"));
            var text = await FileIO.ReadTextAsync(file);
            var html = m.Transform(text);
        }

        [TestMethod]
        public async Task markdownExampleMedium2()
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(
                new System.Uri("ms-appx:///benchmark/markdown-example-medium-2.text"));
            var text = await FileIO.ReadTextAsync(file);
            var html = m.Transform(text);
        }

        [TestMethod]
        public async Task markdownExampleShort1()
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(
                new System.Uri("ms-appx:///benchmark/markdown-example-short-1.text"));
            var text = await FileIO.ReadTextAsync(file);
            var html = m.Transform(text);
        }

        [TestMethod]
        public async Task markdownExampleShort2()
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(
                new System.Uri("ms-appx:///benchmark/markdown-example-short-2.text"));
            var text = await FileIO.ReadTextAsync(file);
            var html = m.Transform(text);
        }

        [TestMethod]
        public async Task markdownReadme32()
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(
                new System.Uri("ms-appx:///benchmark/markdown-readme.32.text"));
            var text = await FileIO.ReadTextAsync(file);
            var html = m.Transform(text);
        }

        [TestMethod]
        public async Task markdownReadme8()
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(
                new System.Uri("ms-appx:///benchmark/markdown-readme.8.text"));
            var text = await FileIO.ReadTextAsync(file);
            var html = m.Transform(text);
        }

        [TestMethod]
        public async Task markdownReadme()
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(
                new System.Uri("ms-appx:///benchmark/markdown-readme.text"));
            var text = await FileIO.ReadTextAsync(file);
            var html = m.Transform(text);
        }
    }
}
