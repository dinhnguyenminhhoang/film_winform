using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmApp.Utils
{
    public class UtilsFnc
    {
        public async Task LoadImageAsync(string posterPath, PictureBox pictureBox)
        {
            try
            {
                if (posterPath.StartsWith("http", StringComparison.OrdinalIgnoreCase))
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var response = await client.GetAsync(posterPath);
                        response.EnsureSuccessStatusCode();

                        using (var stream = await response.Content.ReadAsStreamAsync())
                        {
                            pictureBox.Image = Image.FromStream(stream);
                        }
                    }
                }
                else
                {
                    if (File.Exists(posterPath))
                    {
                        pictureBox.Image = Image.FromFile(posterPath);
                    }
                    else
                    {
                        throw new FileNotFoundException("File not found at specified path.", posterPath);
                    }
                }

                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async Task LoadVideo(string videoUrl, WebView2 webView2)
        {
            await webView2.EnsureCoreWebView2Async(null);
            if (webView2.CoreWebView2 != null)
            {
                webView2.CoreWebView2.Navigate(videoUrl);
            }
            else
            {
                MessageBox.Show("WebView2 is not initialized.");
            }
        }
    }
}
