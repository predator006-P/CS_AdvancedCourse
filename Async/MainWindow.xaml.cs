using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Async
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //DownloadHtmlAsync("http://msdn.microsoft.com");
            var getHtmlTask = GetHtmlAsync("http://www.nso.hu");
            MessageBox.Show("Waiting for the task to complete");
            var html = await getHtmlTask;
            MessageBox.Show(html.Substring(0, 100));
        }

        public string GetHtml(string url)
        {
            var webClient = new WebClient();
            return webClient.DownloadString(url);
        }


        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"C:\Users\Peti\Source\Repos\predator006-P\CS_AdvancedCourse\Async\result.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }
        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"C:\Users\Peti\Source\Repos\predator006-P\CS_AdvancedCourse\Async\result.html"))
            {
                streamWriter.Write(html);
            }
        }
    }
}
