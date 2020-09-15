using System;
using System.Net;
using System.IO;

namespace HackSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
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
            Console.WriteLine("HACK SET V1.0");
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
                string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
                Console.WriteLine("Your Hostname is: " + hostName);
                Console.WriteLine("Your IP: " + myIP);
                Console.WriteLine("-Back");
                string ipBack = Console.ReadLine();
                if(ipBack == "Back"){
                    Console.Clear();
                    goto Start;
                }
                break;

                case "Tools":
                Console.Clear();
                Console.WriteLine("Tool Categories:");
                Console.WriteLine("-Pinger");
                Console.WriteLine("-Ratting");
                Console.WriteLine("-Cracking");
                Console.WriteLine("-Crypting");
                Console.WriteLine("-Ddos");
                Console.WriteLine("-Tracking");
                Console.WriteLine("-Back");
                switch(Console.ReadLine()){
                    case "Pinger":
                    Console.Clear();
                    Console.WriteLine("Pinger");
                    goto Start;

                    case "Ratting":
                    Console.Clear();
                    Console.WriteLine("None RAT functions are added to this version");
                    goto Start;

                    case "Cracking":
                    Console.Clear();
                    Console.WriteLine("None Cracking functions are added to this version");
                    goto Start;

                    case "Back":
                    Console.Clear();
                    goto Start;

                    default:
                    Console.Clear();
                    Console.WriteLine("Unknown Command");
                    goto Start;
                    }
                break;

                case "Database":
                Console.Clear();
                Console.WriteLine("Database to save all data you hacked/cracked or whatever");
                Console.WriteLine("Commands:");
                Console.WriteLine("-Wifi");
                Console.WriteLine("-People");
                Console.WriteLine("-Passwords");
                Console.WriteLine("-Back");
                switch(Console.ReadLine()){
                    case "Wifi":
                    Console.Clear();
                    System.IO.Directory.CreateDirectory("database");
                    System.IO.Directory.CreateDirectory(@"database/wifi");
                    Console.WriteLine("Wifi Password Database");
                    Console.WriteLine("Commands");
                    Console.WriteLine("-Add");
                    Console.WriteLine("-Delete");
                    Console.WriteLine("-List");
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
                            goto Start;

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
                        break;

                        case "Delete":
                        break;

                        case "List":
                        break;

                        case "Back":
                        Console.Clear();
                        goto Start;

                        default:
                        Console.Clear();
                        goto Start;
                    }
                    break;

                    case "People":
                    Console.Clear();
                    System.IO.Directory.CreateDirectory("database");
                    System.IO.Directory.CreateDirectory(@"database/people");
                    Console.WriteLine("People Database");
                    Console.WriteLine("Commands:");
                    Console.WriteLine("-Add");
                    Console.WriteLine("-Delete");
                    Console.WriteLine("-List");
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
                            goto Start;

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

                        case "Passwords":
                        break;

                        case "Back":
                        Console.Clear();
                        goto Start;

                        default:
                        Console.Clear();
                        goto Start;
                    }
                    break;

                    case "Passwords":
                    Console.Clear();
                    System.IO.Directory.CreateDirectory("database");
                    System.IO.Directory.CreateDirectory(@"database/passwords");
                    Console.WriteLine("Account Passwords Database");
                    break;

                    case "Back":
                    Console.Clear();
                    goto Start;

                    default:
                    Console.Clear();
                    Console.WriteLine("Unknown Command");
                    goto Start;
                }
                break;

                case "Help":
                Console.Clear();
                Console.WriteLine("Under Construction");
                goto Start;

                case "Exit":
                break;

                default:
                Console.Clear();
                Console.WriteLine("Unknown Command");
                goto Start;
            }
        }
    }
}
