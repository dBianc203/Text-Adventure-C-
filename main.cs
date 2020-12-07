using System;

class MainClass {
  public static void Main (string[] args) {

    Container<Item> inventory = new Container<Item>(0);
    Leviathan Marcus = new Leviathan();
    Ghost casper = new Ghost();
    Skeleton jack = new Skeleton();
    Drake Toothless = new Drake();
    Hydra Squirtle = new Hydra();
    Dracula Frank = new Dracula();


System.Console.Clear();

System.Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////"); 
System.Console.WriteLine("/////		            Welcome to Devon's Adventure Game!                          /////");
System.Console.WriteLine("///// 				                Staring			    		                    /////");
System.Console.WriteLine("/////				                  YOU!					                        /////");
System.Console.WriteLine("/////			           well at least YOUR character 	  		                /////");
System.Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////");
System.Console.WriteLine();
System.Console.WriteLine("Press any key to start your adventure..."); 
Console.ReadKey(); 
System.Console.Clear();
System.Console.WriteLine("                                                    ````````````````````````````````                               `````````````````````````````````                                              ");      
System.Console.WriteLine("                                                   `hyhhhhhhhhhhhhhhhhhhhhhhhhhhyhhy+-`                           `yyhhhhhhhhhhhhhhhhhhhhhhhhhhhhyy+                                              ");      
System.Console.WriteLine("                                                   `ddddddddddddddddddddddddddddddddddy+-`                        `ddddddddddddddddddddddddddddddddo                                              ");      
System.Console.WriteLine("                                                   `dddddddddddddddddddddddddddddddddddddyo-`                     `ddddddddddddddddddddddddddddddddo                                              ");      
System.Console.WriteLine("                                                   `ddddddddddddddddddddddddddddddddddddddddho:`                  `ddddddddddddddddddddddddddddddddo                                              ");      
System.Console.WriteLine("                                                   `dddddddddddddddddddddddddddddddddddddddddddhs:.`              `ddddddddddddddddddddddddddddddddo                                              ");   
System.Console.WriteLine("                                                   `ddddddddddddddddddddddddddddddddddddddddddddddds/.`           `ddddddddddddddddddddddddddddddddo                                              ");      
System.Console.WriteLine("                                                   `dddddddddddddddddddddddddddddddddddddddddddddddddds/.`        `ddddddddddddddddddddddddddddddddo                                              ");      
System.Console.WriteLine("                                                   `dddddddddddddddddddddddddddddddddddddddddddddddddddddy+.`     `ddddddddddddddddddddddddddddddddo                                              ");      
System.Console.WriteLine("                                                   `ddddddddddddddddddddddddddddddddddddddddddddddddddddddddy+-`  `ddddddddddddddddddddddddddddddddo                                              ");      
System.Console.WriteLine("                                                   `dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddho-`ddddddddddddddddddddddddddddddddo                                              ");      
System.Console.WriteLine("                                                   `ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddhddddddddddddddddddddddddddddddddo                                              ");      
System.Console.WriteLine("                                                   `dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddo                                              ");      
System.Console.WriteLine("                                                   `dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddo                                              ");      
System.Console.WriteLine("                                                   `dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddo                                              ");      
System.Console.WriteLine("                                                   `dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddo                                              ");      
System.Console.WriteLine("                                                   `dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddo                                              ");      
System.Console.WriteLine("                                                   `ddddddddddddddddy+:..-/shddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddo                                              ");      
System.Console.WriteLine("                                                   `dddddddddddddy+-`       .:ohdddddddddddddddddddddddddddy+/:/oydddddddddddddddddddddddddddddddddo                                              ");      
System.Console.WriteLine("                                                   `ddddddddddho-`             .:ohdddddddddddddddddddddy+-`     `-+yddddddddddddddddddddddddddddddo                                              ");      
System.Console.WriteLine("                                                   `dddddddho-`                   `-oydddddddddddddddy+-`           `.+ydddddddddddddddddddddddddddo                                              ");      
System.Console.WriteLine("                                                   `ddddho:`                         `-+yddddddddddo-`                 `./shdddddddddddddddddddddddo                                              ");      
System.Console.WriteLine("                                                   `dho:`                               `-+yhddddddy+-`                   `.:shddddddddddddddddddddo                                              ");      
System.Console.WriteLine("                                                   `:`                                     `./shddddddy+-`                    .:ohdddddddddddddddddo                                              ");      
System.Console.WriteLine("                                                                                              `./shddddddy+-`                    `-oyddddddddddddddo                                              ");      
System.Console.WriteLine("                                                                                                  .:ohddddddy+-`                    `-+yhddddddddddo                                              ");      
System.Console.WriteLine("                                                                                                     `-+yddddddy+-`                    `-+yddddddddo                                              ");      
System.Console.WriteLine("                                                                                                        `-/shdddddho:.`                   `-/shddddo                                              ");      
System.Console.WriteLine("                                                                                                            `:+yhddddhy+:.`                   ./shdo                                              ");      
System.Console.WriteLine("                                                                                                                `-/syhddddyo/.``                 .::                                              ");      
System.Console.WriteLine("                                                                                                                     `-/+syhddhs+:.``                                                             ");      
System.Console.WriteLine("                                                                        ``````````                                         `.-::/++/:.                                                            ");      
System.Console.WriteLine("                                                             ```.--::://////++++//////:::--..```                                                                                                  ");      
System.Console.WriteLine("                                                        `.-://+++oo+oooooooooooooooooooo+ooo+++//::-.```                                         ```                                              ");      
System.Console.WriteLine("                                                    `.-/++o+o+ooooo+ooooooooooooooooooooo+ooooooo+o+o+++/::--.```                         ```.-:/++:                                              ");      
System.Console.WriteLine("                                                   `/+++ooooooooooooooooooooooooooooooooooooooooooooooooooooo+o++++///::::---------::::///++++oooo+:                                              ");      
System.Console.WriteLine("                                                   `:+ooooooooooooooooooooooooooooooooooooooooooooooooooooooo+oooooooo++o++oo+oo++ooooooooooooo+o++.                                              ");      
System.Console.WriteLine("                                                    `:+oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo+.                                               ");      
System.Console.WriteLine("                                                      `-/++ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo+++:.`                                                ");      
System.Console.WriteLine("                                                         `-/+oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo+o+:.`                                                   ");      
System.Console.WriteLine("                                                           `.:/+oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo+++:-`                                                      ");      
System.Console.WriteLine("                                                              `.-/+++ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo++++/-`                                                         ");      
System.Console.WriteLine("                                                                 `.-/+oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo+:.`                                                            ");      
System.Console.WriteLine("                                                                    `.-/+o+++oooooooooooooooooooooooooooooooooooooooooooooooo+++:.`                                                               ");      
System.Console.WriteLine("                                                                       `.-/+ooo+ooooooooooooooooooooooooooooooooooooooooooo++:.`                                                                  ");      
System.Console.WriteLine("                                                                          `.-/++oooooooooooooooooooooooooooooooooooooooo++:-`                                                                     ");      
System.Console.WriteLine("                                                                             `.-/+++ooooooooooooooooooooooooooooooooo++/-`                                                                        ");      
System.Console.WriteLine("                                                                                `.:/+o+ooooooooooooooooooooooooooo++/-`                                                                           ");      
System.Console.WriteLine("                                                                                   `.:/+o+ooooooooooooooooooooo++:-``                                                                             ");      
System.Console.WriteLine("                                                                                      `.:/+o+ooooooooooooooo++/-`                                                                                 ");      
System.Console.WriteLine("                                                                                         `.:/+oooooooooo+++/-`                                                                                    ");      
System.Console.WriteLine("                                                                                            `.:/+ooo+o++/-`                                                                                       ");      
System.Console.WriteLine("                                                                                               `.:/++/-`                                                                                          ");      
System.Console.WriteLine("                                                                                                  `.`                                                                                             ");      
System.Console.WriteLine("                                                                                                                                                                                                  ");      
System.Console.WriteLine("                                                                                                                                                                                                  ");      
System.Console.WriteLine("                                                                                                                                                                                                  ");      
System.Console.WriteLine("                                                                                                                                                                                                  ");      
System.Console.WriteLine("                                                        `.-/-                                                                                                                                     ");      
System.Console.WriteLine("            .--::`     --:-.                            `+ddo                                             .-:::--`   --::.                                                                        ");      
System.Console.WriteLine("             .hddh:    `:h.`                       ./    `hdo                                             `.smdo`    `oh-`                                                            `+          ");      
System.Console.WriteLine("              h/hddo`   .h    `.:::.    `.:``-:. `+hy...``hdo `-:-`     .:::.   `.:``-:. ``-- `-:-`         `ydd-    .d.  .:::.   `.:``-:. `.-. .::.  `-/:`    `.:::.   ``.- `-:-`  `/hd...`      ");      
System.Console.WriteLine("              h.`+ddd/  .h  `odo``:hh: .smm++hmh.+ydh+++.`hds/oohdh.  :ho.`:dy-.omm++hdd`/hdh/ooydd-         .hdh`  `h: /ho.`:dy..omm++hmh.odmo+osdds/oohdd. `odo.`:hh/ :hdh/ooymd-`/ydd+++-      ");      
System.Console.WriteLine("              h.  .ydds..h `ydy`   :mm- .mm: `.`  sdy     hd+   .mm/ /dh::::hdy``md/  .`  odh`  `dd+          -dds` o+ +dh::::hdy`.dd/  .` `hm/   sdh`  .md:`sdh`   :dm: odh`  `dd+  +dd`         ");      
System.Console.WriteLine("              h.   `/ddd+y .mds    .md+ .mm:      sdy     hdo   .dm/ ydh``````` `md/      odh`  `hd+           /dd+:s  hdh.`````` .dd/     `dm/   odh`  .mm:`dds    .md+ odh`  `dd+  +dd`         ");      
System.Console.WriteLine("              h.     .sddy `ydh`   :md. .mm:      sdy`   `hdo   .dm/ +dd:       `md/      odh`  `dd+           `oddy`  odd:       `dd/     `dm/   odh`  .mm:`ydh`   :dd- odh`  `dd+  +dd`         ");      
System.Console.WriteLine("            .:h+-     `:hy  `oho-./hs- ./dd+.     +dds+:.:hds. `/ddo.`/ydyo++/-`:ddo-    -sdh:``:dds-           `yd.   `+hdyo++/-`/ddo-   `/dds. -sdh:``/dd+.`ohs-./hs- -sdh:``:dds- :dms+/`      ");      
System.Console.WriteLine("            ``.``       ``    `.--.`   ```.``      .-..```...`  `..``  `.--.`` ``.`.`    ``.``  `..``            `.      `.---`` ``..``    `..`` ``.`` ``..``  `.--.`   ``..`  `..``  ..-.`       ");      
System.Console.WriteLine("                                                                                                                                                                                                  ");      
System.Console.WriteLine("                                                    .-   ..    `-.  `-`    -.    .-   `-`   `-----`   `----.`    `.--.`    `-`   `------`   .-`  .-`                                              ");      
System.Console.WriteLine("                                                    /+`  /+`   -++-`-o`   `+:    .+- `//`   .o:---`   .o:.-+:   `//-.:-`   -o.   `.-++-.`   `//.-+-`                                              ");      
System.Console.WriteLine("                                                    /+` `/+`   -+-//:o.   `+:     :+.:+.    .o/:::    .o/:/+-    -///:-    -o.     `//`      `:++-                                                ");      
System.Console.WriteLine("                                                    -+-.-+/`   -+.`:+o.   `+:     `/++-     .o:-..    .o:-+/`    -:.-/+`   -o.     `//        `+:`                                                ");      
System.Console.WriteLine("                                                    `.:::-`    .:`  .:`   `:-      `:-      `:::-:`   `:. `:.    .-::-.    .:`      --        `:-                                                 ");                                                                     
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine("You wake up on the ground outside of Rita-bowl on the NVU-Lyndon campus.");
System.Console.WriteLine("You notice a sign in front of you with the universitys' logo.");
System.Console.WriteLine("You also notice two double doors, around 10 yards in front of you.");
System.Console.WriteLine("You enter through the double doors in front of you.");
System.Console.WriteLine();
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();

System.Console.WriteLine("ohhhhyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyssssssyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyhhhhhhhhyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyssssssyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyhh");
System.Console.WriteLine("ohhyyyyyyyyyyyyyyyyyyyyyyyysssssssssssssssssssssssyyyyyyyyyyyyyyyyyyyyyyyyhhhhyyyyyyyyyyyyyyyyyyyyyyyyysssssssssssssssssssssyyyyyyyyyyyyyyyyyyyyyyyyyh");
System.Console.WriteLine("ohyyyyyyyyyyyyyyyyyyyyysssssssssssssssssssssssssssssssyyyyyyyyyyyyyyyyyyyyyhhyyyyyyyyyyyyyyyyyyyyysssssssssssssssssssssssssssssssyyyyyyyyyyyyyyyyyyyyy");
System.Console.WriteLine("oyyyyyyyyyyyyyyyyyyysssssssssssssssssssssssssssssssssssssyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyysssssssssssssssssssssssssssssssssssssyyyyyyyyyyyyyyyyyy");
System.Console.WriteLine("oyyyyyyyyyyyyyyyyysssssssssssssssssssssssssssssssssssssssssyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyysssssssssssssssssssssssssssssssssssssssssyyyyyyyyyyyyyyyy");
System.Console.WriteLine("oyyyyyyyyyyyyyyysssssssssssssssssssssssssssssssssssssssssssssyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyssssssssssssssssssooooooooossssssssssssssssssyyyyyyyyyyyyyy");
System.Console.WriteLine("oyyyyyyyyyyyyysssssssssssssssssssddddddddddysssssssssssssssssssyyyyyyyyyyyyyyyyyyyyyyyyyyyssssssssssssssssssmmmmmdmmmmhossssssssssssssssssyyyyyyyyyyyy");
System.Console.WriteLine("oyyyyyyyyyyyysssssssssssssssssssymmmmddmmmmyssssssssssssssssssssyyyyyyyyyyyyyyyyyyyyyyyyssssssssssssssssssssmmmmdymmmmhosssssssssssssssssssyyyyyyyyyyy");
System.Console.WriteLine("oyyyyyyyyyyyssssssssssssssssssssoyyyyyyyyyyssssssssssssssssssssssyyyyyyyyyyyyyyyyyyyyyyssssssssssssssssssssoyyyyyyyyyysossssssssssssssssssssyyyyyyyyyy");
System.Console.WriteLine("oyyyyyyyyyysssso++++////////:::::::::::::::::::::///////+++ossssssyyyyyyyyyyyyyyyyyyyysssso++++/////::::::::::::---:::::::::::://///++osyssssyyyyyyyyy");
System.Console.WriteLine("+yyyyyyyyyssssyo++///::---------....```.......-------:::/++oyssssssyyyyyyyyyyyyyyyyyyssssys++///:::--------.....``.......-------:::/++osysssssyyyyyyyy");
System.Console.WriteLine("+yyyyyyyysssssyo++yyysssooooooo++++++///++++++oooooossssys+ossssssssyyyyyyyyyyyyyyyysssssss++hyyyssssssooooooooooooooooooooossssssyyy+ooyssssssyyyyyyy");
System.Console.WriteLine("+yyyyyyyysssssyoo/yssssooooooooo++++++++++++++oooooooossss/osssssssssyyyyyyyyyyyyyyyssssssso/ddhhyyyssssssssssssssssssssssssssyyyhhdd+ooysssssssyyyyyy");
System.Console.WriteLine("+yyyyyyyssssssyo+/s+syysssooo+++++///////+++++ooossyyyys+s/+ossssssssyyyyyyyyyyyyyyssssssso+/ddhyssooooooooooooo+oooooooooooooossyyhd++oysssssssyyyyyy");
System.Console.WriteLine("+yyyyyyysssssss+/:s+ssssoo++////:::-....-::///+++oosssso+s:/ossssssssyyyyyyyyyyyyyyssssssso/:dhyssoo+++++++++++++++++++++++++++oosyhd//+ysssssssyyyyyy");
System.Console.WriteLine("+yyyyyyysssssss+/:s/++oooo++///:::--....-:::///++oosso/++o:/+sssssssssyyyyyyyyyyyyysssssss+/:dhyso+++/////////////////////////++osshd//+sssssssssyyyyy");
System.Console.WriteLine("+yyyyyyssssssss/:-o/:.:/ooo++++///::---::://++++oooo/-.//o-:+sssssssssyyyyyyyyyyyyysssssss+:-hhsoo+///:::::::::::/::::::::::///++osyh/:/ssssssssyyyyyy");
System.Console.WriteLine("+yyyyyyssssssss/--o/-``.///:::----........---:::///:.` :/o--+sssssssssyyyyyyyyyyyyysssssss/--hhso+//:::::::::::::/:::::::::::://+osyh:-/ssssssssyyyyyy");
System.Console.WriteLine("+yyyyyyssssssss:--o/-```::--...````     ````...---:-`  :/o.-/sssssssssyyyyyyyyyyyyysssssss/--hyo+//::------------:------------://+oyh:-:sssssssssyyyyy");
System.Console.WriteLine("+yyyyyyysssssss:.-o:-```:--...````       ````...--:-`  :/o../ssssssssyyyyyyyyyyyyyysssssss/..hyo+/::--..........-:..........---:/+oyh:.:ysssssssyyyyyy");
System.Console.WriteLine("+yyyyyyysssssss-..o:-``.---..````         ````...-:-`  :/o../ssssssssyyyyyyyyyyyyyysssssss:..hyo+/:--............-............-::/+yy-.-ysssssssyyyyyy");
System.Console.WriteLine("+yyyyyyyysssssy-`.o::`..--..````           ````..---`  :/o``:ssssssssyyyyyyyyyyyyyysssssss:``yy+/:--..``````````.-``````````...-:/+sy-`-ysssssssyyyyyy");
System.Console.WriteLine("+yyyyyyyysssssy-`.o::...--..```             ````..--`` :/o``:sssssssyyyyyyyyyyyyyyyyssssss:``yy+/:-..```````````.-````````````.-:/+sy-`-yssssssyyyyyyy");
System.Console.WriteLine("+yyyyyyyyyssssy-`.o::...--.````             ````..--`` :/o``:sssssssyyyyyyyyyyyyyyyyssssss:``ys+/:-.`````````````.````````````..-:+sy-`.ysssssyyyyyyyy");
System.Console.WriteLine("+yyyyyyyyyysssy. .o::..--..```               ````.--`` :/o` :ssssssyyyyyyyyyyyyyyyyyyssssy: `ys+/-..``          `.           ``.-:/sy. .yssssyyyyyyyyy");
System.Console.WriteLine("oyyyyyyyyyysssy. .s::..--..``                 ```...```:/o` :yssssyyyyyyyyyyyyyyyyyyyysssy: `ys+:-..`           `.           ``.-:/sy. .yssssyyyyyyyyy");
System.Console.WriteLine("oyyyyyyyyyyyssy. .s::.---.```                 ```...```:/s` :ysssyyyyyyyyyyyyyyyyyyyyyyysy: `ys+:-.``           `.           ``.-:/sy. .ysssyyyyyyyyyy");
System.Console.WriteLine("oyyyyyyyyyyyyyy. .s::----..``````````````````````..-.``:/s` :yssssyyyyyyyyyyyyyyyyyyyyyyyy: `ys+:-..`           `.           ``.-:/sy. .ysysssyyyyyyyy");
System.Console.WriteLine("oyyyyyyyyyyyyyy-`.s:/::/---------------------------:::://s``:yyo--+yyyyyyyyyyyyyyyyyyyyyyy:``ys+:-..``          `.           ``.-:/sy-`.yys--:yyyyyyyy");
System.Console.WriteLine("oyyyyyyyyyyyyyy-`.s:/://:--------------------------://:+/s``:yyo `:yyyyyyyyyyyyyyyyyyyyyyy:``ys+/-..``          `.           ``.-:/sy-`-yys``.yyyyyyyy");
System.Console.WriteLine("oyyyyyyyyyyyyyy-.-s//://:::/::::::::::::::::::::/::://:+/s../yys.-/yyyyyyyyyyyyyyyyyyyyyyy/..ys+/:-.```         `.          ``..-:+sy-.-yyy--:yyyyyyyy");
System.Console.WriteLine("oyyyyyyyyyyyyyy:.-y/////:--:--------------------:--://:+/s../yyyoosyyyyyyyyyyyyyyyyyyyyyyy/..ys+/:-.`````````````.````````````..-:+sy-.:yyysosyyyyyyyy");
System.Console.WriteLine("ohyyyyyyyyyyyyy/--y/////:--------------------------:///++s--+yyyyyyyyyyyyyyhhyyyyyyyyyyyyy+--ys+/:-..````````````-````````````.-:/+sy:-/yyyyyyyyyyyyyy");
System.Console.WriteLine("ohhhyyyyyyyyyyy/::y/////:--------------------------:///++s-:+yyyyyyyyyyyyhhhhhhyyyyyyyyyyy+:-yy+/:-...``````````.-```````````..-:/+sy::/yyyyyyyyyyyyhh");
System.Console.WriteLine("ohhhhhyyyyyyyyy+/:y/+///:--------------------------:///++s:/oyyyyyyyyyyhhhhhhhhhyyyyyyyyyyo/:yy+/:--..``````````.-``````````...-:/+sy//+yyyyyyyyyyhhhh");
System.Console.WriteLine("ohhhhhhhyyyyyyho+/s:+///---------------------------:///+/s/+syyyyyyyyyhhhhhhhhhhhhhyyyyyyyo+:yyo//:-.............-............--:/+sy/+ohyyyyyyyhhhhhh");
System.Console.WriteLine("ohhhhhhhhyyyyyh:.-s.+//+-..........................:+///-s..+yyyyyyhhhhhhhhhhhhhhhhhhyyyyh/..yyo+/:--...........--...........--::/oyy:.:hyyyyyhhhhhhhh");
System.Console.WriteLine("ohhhhhhhhhhhyyh-`.s.+//+:--------------------------:+///-s``:hyyyhhhhhhhhhhhhhhhhhhhhhhyyh:``yyo+/::---.........-:..........---:/+oyy-`-hyyyhhhhhhhhhh");
System.Console.WriteLine("ohhhhhhhhhhhhhh-`.s-+//+:--------------------------:+///:s.`/hhhhhhhhhhhhhhhhhhhhhhhhhhhhh/`.hyo+//:-------------:------------::/+oyh-`-hhhhhhhhhhhhhh");
System.Console.WriteLine("ohhhhhhhhhhhhhh:.-s-+/++:::::::::::::::::::::::::::/+//+:s../hhhhhhhhhhhhhhhhhhhhhhhhhhhhh/..hyso+/:::-----------:-----------:://+oyh:.:hhhhhhhhhhhhhh");
System.Console.WriteLine("ohhhhhhhhhhhhhh/--s:+/++/::::::::::::::::::::::::::/++/+/s--+hhhhhhhhhhhhhhhhhhhhhhhhhhhhh+--hhso+//:::::::::::::/:::::::::::::/+osyh:-/hhhhhhhhhhhhhh");
System.Console.WriteLine("ohhhhhhhhhhhhhh/::y/+//+++///////////////////////++++//+/s-:ohhhhhhhhhhhhhhhhhhhhhhhhhhhhh+:-hhso++//::::::::::::/:::::::::::///+osyh/:/hhhhhhhhhhhhhh");
System.Console.WriteLine("ohhhhhhhhhhhhhh+/:y//:/+ooo+++++++++////++++++++oooo+/:++y:/ohhhhhhhhhhhhhhhhhhhhhhhhhhhhho/:dhsoo+////////////////////////////++oshh//+hhhhhhhhhhhhhh");
System.Console.WriteLine("ohhhhhhhhhhhhhho+/y+//////:::::-------------::::://///:/+y:+shhhhhhhhhhhhhhhhhhhhhhhhhhhhho+:dhyso+++/////////////////////////++osshd/+ohhhhhhhhhhhhhh");
System.Console.WriteLine("ohhhhhhhhhhhhhho+/h++//:::----...............----:::://+oh/+shhhhhhhhhhhhhhhhhhhhhhhhhhhhhs+/dhysoo++++//////////+//////////+++oosyhd++ohhhhhhhhhhhhhh");
System.Console.WriteLine("ohhhhhhhhhhhhhhso+h+/::-----.........``........-----:::+oh+oyhhhhhhhhhhhhhhhhhhhhhhhhhhhhhyo+ddyysoo++++++++++++++++++++++++++oossyhd+osdhhhhhhhhhhhhh");
System.Console.WriteLine("sddddddddddddddys+y:------------------------------------/y+sydddddddddddddddhhhhhhhhhhhhhdys+dyssooo++++++++++++++++++++++++++oooossdosydhhhhhhhhhhhhh");
System.Console.WriteLine("://////////////++:.                                     `.:++/////////////////////////////+o/:......................................-/o+//////////////");
System.Console.WriteLine("...............``````````````````````````````````````````````.........................................................................................");
System.Console.WriteLine("..............````````````````````````````````````````````````........................................................................................");
System.Console.WriteLine("............```````````````````````````````````````````````````.......................................................................................");
System.Console.WriteLine("............````````````````````````````````````````````````````......................................................................................");
System.Console.WriteLine("......................................................................................................................................................");
System.Console.WriteLine("......................................................................................................................................................");
System.Console.WriteLine("......................................................................................................................................................");
System.Console.WriteLine(".-....................................................................................................................................................");
System.Console.WriteLine();
System.Console.WriteLine("You are met with 2 elevators, one of the left, and one on the right");
System.Console.WriteLine("You decide that you are going to use one of the elevators, but can't decide which one");
System.Console.WriteLine();
System.Console.WriteLine("But before you decide, lets create a character..");

    System.Console.WriteLine("\nWhat is your characters name? ");
    string PCname = System.Console.ReadLine();
    System.Console.WriteLine("Enter your characters speed [1-5] ");
    int Sp33d = Convert.ToInt32(Console.ReadLine());
    while ((Sp33d < 0) || (Sp33d > 6))
    {
      System.Console.WriteLine("Your number was out of bounds! try again");
      Sp33d = Convert.ToInt32(Console.ReadLine());
    }

    System.Console.WriteLine("\n What do you want your characters race to be? ");
    System.Console.WriteLine("Enter 1 for Dragonbron \nEnter 2 for Dwarf \nEnter 3 for Elf \nEnter 4 for Halfling \nEnter 5 for Human \nEnter 6 for Gnome \nEnter 7 for HalfElf \nEnter 8 for HalfOrc \nEnter 9 for Tiefling ");
    int RacePicked = Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine("Interesting....we're not done yet, but lets choose an elevator");
    System.Console.WriteLine("Which elevator do you choose?");
  System.Console.WriteLine("[Enter 1 for the left elevator, and 2 for right elevator]");

  int Elevator = Convert.ToInt32(Console.ReadLine());
  if (Elevator == 1){
   System.Console.WriteLine("You have chosen the left elevator, along with your journey...");
    PlayerCharacter me = new PlayerCharacter(PCname,Sp33d);
    me.ChangeRace(RacePicked);
    System.Console.Clear();
System.Console.WriteLine("______________________________________");
System.Console.WriteLine("|                                    |");
System.Console.WriteLine("| ...................................|");
System.Console.WriteLine("| ..............`     `..............|");
System.Console.WriteLine("| .............`        .............|");
System.Console.WriteLine("| .............`        .............|");
System.Console.WriteLine("| .............         `............|");
System.Console.WriteLine("| ..............       `.............|");
System.Console.WriteLine("| ...............     `..............|");
System.Console.WriteLine("| ...............     `..............|");
System.Console.WriteLine("| .............`       ``............|");
System.Console.WriteLine("| .........``              ``........|");
System.Console.WriteLine("| .......`                    .......|");
System.Console.WriteLine("|____________________________________|");
System.Console.WriteLine(me);
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();
System.Console.WriteLine("You go down in the elevator and find yourself in the basement of the building.. ");
System.Console.WriteLine("You exit the elevator and see a map in front of you.");
System.Console.WriteLine("You look at the map and it comes clear to you that you need to escape!");
    Potion P1 = new HealingPotion();
    P1.recipient = me;
    Potion P2 = new ArmorPotion();
    P2.recipient = me;
    Weapon P3 = new Axe();
    P3.recipient = me;
                                                                                                                                                      
                                                                                                                                                      
System.Console.WriteLine("                    //                                             ``        `                                            .:/++/:.         ");           
System.Console.WriteLine("                   /mm/                    `-`                  -syssys: `+ysosyo`                                     -syo/:--:/oys-      ");           
System.Console.WriteLine("                  :m--m:           ````````:Nss+-`             -m-`  `.hyd+`   `sh                                   .yy-`        `:hs`    ");           
System.Console.WriteLine("                 -m:  :m-         yhssssssssy``:oys/.          yy      `o/      `M-          `.:+osd-.........`     `m+             `sh`   ");           
System.Console.WriteLine("                .m/    /m.        ho             `-smh.        /m`              /m`     ./ossso+:..soooooooood+     sy               `m+   ");           
System.Console.WriteLine("               .d+      +d.       yhooooooooo `-+yy+-`          yy`            :m:      .+shys+/-``++++++++++mo     do                ys   ");           
System.Console.WriteLine("              `hs        sh`      `......../Msso:.`             `oh-         `od-           `.-/+oyd-.........`     +d`              `N:   ");           
System.Console.WriteLine("             `yy          yy`              `:.`                   -yy:`    .+h+`                  ``                `yy.            .ho    ");           
System.Console.WriteLine("             sm::::::::::::ms                                       .oys:+ss/`                                       `+ho.       `-oh/     ");           
System.Console.WriteLine("             /+////////////+/                                         `:mh-                                            `/osoo++ooso:`      ");           
System.Console.WriteLine("                  `os.                                               -yy/+yo.                                             `.-+s/.`         ");           
System.Console.WriteLine("                 /ho/h+`                                           :yd/   `ods-                                          `-oyo/sy/.        ");           
System.Console.WriteLine("               .ym/  .dd:                                         `oohh    Nso+                                        .+dd+`   -ymy/      ");           
System.Console.WriteLine("               -/hs  /m/:                                            +d    M-                                          .+/hy    :N///      ");           
System.Console.WriteLine("                 yy  /m                                              /h++++d-                                             sh....+m         ");           
System.Console.WriteLine("                 ohssyy                       ``                     .++++++.                      `ho-`                  :sooooss         ");           
System.Console.WriteLine("                  `````              .-------ohso/-`              .+ss+/::/+oso-           -soooooosm:+so/.          `-/++/.    .:/+/:.    ");           
System.Console.WriteLine("            :ooso+. `:ooso/.         hy++++++o/`./oys+-         `+h+.        `:ys.         /N........   ./sho`      :ho:--/sy:-sy+---+yo   ");           
System.Console.WriteLine("          oh-``./hshs-``.+d.        hs-------.  .-ohho         yy`            `+d.        /N:::::::-  .:sso:      .N:      -hd:`     `d/   ");          
System.Console.WriteLine("         `N:     `s:      do        /+++++++hh+sso:.          +d`               sh        `///////oMoss/-`        .N-       `.        d+   ");          
System.Console.WriteLine("           ys             -N:                -+:.              m/                .M.               `+:`             od.              `oh`  ");           
System.Console.WriteLine("           `hs`          :d/             `.:-                  m/                `M.           `-:oh.```````         +d/`           -yy`   ");           
System.Console.WriteLine("           `+y+.     `-sy-        `.-/ossoyd//////////-       +d`               sh        `-+sso/:ysssssssd          .sy+.      `:sy:      ");          
System.Console.WriteLine("             ./ys/-:+ys-        +yhy+:.`  `::::::::::hy        yy`            `+d.        +dds:.  .------/M            ./ss+-./oyo-        ");          
System.Console.WriteLine("                ./o+-`          -/osso/-.`.o+++++++++hs        `+h/.        `:ys`           .:+sssNo+++++++               .:oo/.           ");          
System.Console.WriteLine("                                    `-:+sshh.........-`          .+ss+/::/+sso-                 `-/                                        ");          
System.Console.WriteLine("                  `+/                     ..                        .-://:-.                                                 .+.           ");          
System.Console.WriteLine("                 .yyyy.                                                 -.                                                  :dsd.          ");          
System.Console.WriteLine("                /d/  +d/                                              `shd+`                                               +d- /d:         ");          
System.Console.WriteLine("                sNs.  .sNo                                            :ho``sy-                                             /Ny` .hm:       ");           
System.Console.WriteLine("                --N/  +m--                                           /md:  omd-                                            .-M. /N.`       ");           
System.Console.WriteLine("                  m/  +m                                              `ho  ho`                                              `M. /m         ");           
System.Console.WriteLine("                  ms::sd                                               hs..do                                               `No/sm         ");           
System.Console.WriteLine("              ````:////:                                               /soos-                                                -----         ");           
System.Console.WriteLine("          `:ossssssso/.                                                  -.                                          /++++++++++++++++++.  ");           
System.Console.WriteLine("        -sh+-`      ./yy:                                               +mm:                                         ds----------------N/  ");           
System.Console.WriteLine("       +d/             -hs`                                            +d.:m:                     `                  d+                N/  ");           
System.Console.WriteLine("      +m`                yh             ``-/oh/```````````            od.  -m/               ``:+ym:``````````       d+                N/  ");           
System.Console.WriteLine("      N:                 `N-       `./osss+:.sysssssssssyd`          sh`    .m+          `-+sys/-`yyssssssssyd       d+                N/  ");           
System.Console.WriteLine("      M-                  N:     `ymms:`                .M.        `yy`      .d+       -hms/.               -M       d+                N/  ");           
System.Console.WriteLine("      yy                 /m`       .:+ssso/.`oysssssssssym`       `hy         .ds       ./oyyo:`  ++++++++++sN       d+                N/  ");           
System.Console.WriteLine("      `hs`              /d-             `./oyd+                  `dy````````````dy           -/sysN+---------.       d+                N/  ");           
System.Console.WriteLine("        +d+`         `/hy`                                       /yssssssssssssssy-              `:`                 ds----------------N/  ");           
System.Console.WriteLine("         `/syso///+syy+`                                                                                             :++++++++++++++++++.  ");           
System.Console.WriteLine("             `.:::-`                                                                                                                       ");           
                                                                                                                                                      
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();                                                                                                                                                      

System.Console.WriteLine("You notice a hallway going straight, and another hallway going to your left.");
System.Console.WriteLine("Which way do you choose to go?");
System.Console.WriteLine("[Enter up to go straight] or [Enter left to go left]");
string HallWayChoice = System.Console.ReadLine().ToLower();
if(HallWayChoice == "up")
{
  System.Console.WriteLine("You take the path up");
  me.MoveNorth();
                                                                                                      
System.Console.WriteLine("                                             ..--://+++.                                            ");
System.Console.WriteLine("                                             .-:/++osyy`                                            ");
System.Console.WriteLine("                                             ..-/+ossyo                                             ");
System.Console.WriteLine("                                           ``.-:+osyyyo```                                          ");
System.Console.WriteLine("                                          .``..+syhdddy:..                                          ");
System.Console.WriteLine("                                          .`...+osyhhhs:.-                                          ");
System.Console.WriteLine("                                          ....-+ooyyyy+/.-                                          ");
System.Console.WriteLine("                                           ..-/ssyyhhy/:.`                                          ");
System.Console.WriteLine("                                           `..-::/:/ooooo/                                          ");
System.Console.WriteLine("                                         `-:-::+o:+shyss+                                           ");
System.Console.WriteLine("                                        `:///////ooosy+/-                                           ");
System.Console.WriteLine("                                          `-+oo/o+:+hhyys++                                         ");
System.Console.WriteLine("                                         ``.-::://:oo.-+o:                                          ");
System.Console.WriteLine("                                           ``.---:o:`:+o`                                           ");
System.Console.WriteLine("                                               ` -++`+++                                            ");
System.Console.WriteLine("                                                `` .+o`oo/                                          ");
System.Console.WriteLine("                                                ````/o`oo/                                          ");
System.Console.WriteLine("                                                ````:o-+o+                                          ");
System.Console.WriteLine("                                                ````:o:/oo                                          ");
System.Console.WriteLine("                                                ````.-`-+o`                                         ");
System.Console.WriteLine("                                           `    ````````:o-                                         ");
System.Console.WriteLine("                                           `   `````````-++                                         ");
System.Console.WriteLine("                                          .`   ``````..../-                                         ");
System.Console.WriteLine("                                         ``.`....````......`                                        ");
System.Console.WriteLine("                                       `.....`````````..``..``                                      ");
System.Console.WriteLine("                                     ``....``.```.....``````..``                                    ");
System.Console.WriteLine("                                  ``..--::::://::::::::::---.....`                                  ");
System.Console.WriteLine("                                 :++///////////::::::///////:://++/`                                ");
System.Console.WriteLine("                                :syo/:/ooooooo+++/////++ooooosssyys+`                               ");
System.Console.WriteLine("                               -oy+-.-:+++ssyysoo+++++ossyysssyyysso:                               ");
System.Console.WriteLine("                               +oo-.-:/:-:/oyysoooooooosssyysssyyyys+`                              ");
System.Console.WriteLine("                              `+s/..-/:---/syyyyyyyyyyyyyyyyyssssysso-                              ");
System.Console.WriteLine("                              .+s+::/+:--:+hhhhhhhhhhhhhhhhyyyyssssso-                              ");
System.Console.WriteLine("                              .+oo++oo+//+yhddddddddhdddddddyysssssso-                              ");
System.Console.WriteLine("                              .+ooosssyyyyhdmmdddmddmmdmdmdddhyssssoo-                              ");
System.Console.WriteLine("                              `+osssshdddddmmmmmdmmmmmmmmddmdddhsssso-                              ");
System.Console.WriteLine("                              `/oosyhmmmmmmmmmmmmmmmmmmmmmmmmmmdyysso.                              ");
System.Console.WriteLine("                               -+ssydddmmmmmmmmmmmmmmmmmmmmmmmmdhyys+`                              ");
System.Console.WriteLine("                               `/osyddddddmmmmmmmmmmmmmmmmmmmmdddhyo-                               ");
System.Console.WriteLine("                               `./osyddddmmmmmmmmmmmmmmmmmmmmmddhys:``                              ");
System.Console.WriteLine("                               ``./+oyhdddmmmmmmmmmmmmmmmmmmddhhys/-.``                             ");
System.Console.WriteLine("                               ``.-:/osyyhhhddddddddddddddddhdhys+:-.``                             ");
System.Console.WriteLine("                                ``..--:/+osyyhhhdddddddddhhyso+/:--.``                              ");
System.Console.WriteLine("                                  ````.....----:::::::::::----....```                               ");
System.Console.WriteLine("                                     `````````````````````````````                                  ");

 System.Console.WriteLine("In this room you discovered a potion of healing that heals for 25hp Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No]");
 int pickup = Convert.ToInt32(Console.ReadLine());
 if(pickup == 1)
    {
       inventory.Add(P1);
       System.Console.WriteLine("You added a healing potion to your inventory");
    }
  if(pickup == 2)
    {
      System.Console.WriteLine("You left the potion to itself and continue your journey");

      }
    System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem = System.Console.ReadLine().ToLower();
    
    if(UseItem == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
     if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }

       }
 System.Console.WriteLine("Press any key to continue..."); 
 Console.ReadKey(); 
 System.Console.Clear();
                                                                                                    
  System.Console.WriteLine("You notice a hallway going straight, and another hallway going to your left.");
  System.Console.WriteLine("Which way do you choose to go?");
  System.Console.WriteLine("[Enter up to go straight] or [Enter left to go left]");
  string HallWayChoice2 = System.Console.ReadLine().ToLower();
  if(HallWayChoice2 == "up")
  {
    System.Console.WriteLine("You take the path up");
    me.MoveNorth();
    System.Console.WriteLine("In this room you encounter a vampire, you have no choice but to fight for your life!");
System.Console.WriteLine("                                                -/oyhdddhys/.                                       ");
System.Console.WriteLine("                                             `+dmNmmmNNNNNNNm+                                      ");
System.Console.WriteLine("                                            /dmdysooyyyyhmNNNm+                                     ");
System.Console.WriteLine("                                           :ho:--:+so/:--:+shmm+                                    ");
System.Console.WriteLine("                                          `y+:...--:------:/oymd                                    ");
System.Console.WriteLine("                                        .`-o:oyo/-.--.:/+ss//hmd                                    ");
System.Console.WriteLine("                                       `:::::/+oho/:/osyy+///mNo`..                                 ");
System.Console.WriteLine("                                        ://-:-:::--./-:///::/sh:::.                                 ");
System.Console.WriteLine("                                        -/::------../:-.---:/+o//-                                  ");
System.Console.WriteLine("                                     /`  .-///:---::+:---////++:-` :.                               ");
System.Console.WriteLine("                                     dd+. `://s.:::::::-yo////.`  `dy                               ");
System.Console.WriteLine("                              ```` ` /NNmy+/::/+hhysyy/o+:://- `-/yNy                               ");
System.Console.WriteLine("                           ..-:+/.``` omNNNm+::/yyyysso/::/+ssydmmmm-                               ");
System.Console.WriteLine("                          . .:+s+-../  +mNNNmo::::::/::::/odNNNNNmd:     ``                         ");
System.Console.WriteLine("                         `.`.-//:://:   -ymNNms:::::::::/+mmNNNmho.     `::```                      ");
System.Console.WriteLine("                         .::/ossyyho/     :dmmh`-::::--/osNmmmm+.`..   .-:-:::`                     ");
System.Console.WriteLine("                          .:/oosssy+`    .ymN++` ````.oo:hNNdmdy. .--.---::/:-                      ");
System.Console.WriteLine("                           .::::+++`     odmd``.:`.--.:-:mddddNdd/ -::::::/:/-                      ");
System.Console.WriteLine("                            .::-++/`.    hmm:  ./.:+-..-oNNddNNNmmo`::::::/::.                      ");
System.Console.WriteLine("                             .:.++./my/.-dm/  ..-..-``..hNdmNmNNmmmy`-///:-`                        ");
System.Console.WriteLine("                               .+-/dNNNNmdo  `.-.--.....mdmNmymmmdmNs:-:`                           ");
System.Console.WriteLine("                            `.://:odmNNNNd`    `. ```...smNNhyymmmNNNmh:                            ");
System.Console.WriteLine("                            ......` -+ymm+`   `.`  ``...:dNmyyyymNNNNNNm-                           ");
System.Console.WriteLine("                                       sd/`   :s/` ```..-omNhyyyyhdhmNNNm/                          ");
System.Console.WriteLine("                                       yhNy-+dNNNm+``./sdNdNmyyyyyyyhmNNNN/                         ");
System.Console.WriteLine("                                       odNNmNNNNNNNddmmNNNmmNhyyyyyyyhNNNNN/                        ");
System.Console.WriteLine("                                       .mNNNNNNNNNNNNNNNNNNdNdyyyyyyyhdNNNNm/                       ");
System.Console.WriteLine("                                        hNNNNNNNNNNNNNNNNNNNmmyyyyyyyhymNNNNm-                      ");
System.Console.WriteLine("                                        /NNNNNNNNNNNNNNNNNNNmmyyyyyyyhyhNNNNNd`                     ");
System.Console.WriteLine("                                       `-mNNmmmmmddddmNNNNNNNmyyyyyyyhyymNNNNNs                     ");
System.Console.WriteLine("                    `-.`          .:oyddmNNNNNNNNNddmmNNNNNNNNhyyyyyyyyyhNNNNNm.                    ");
System.Console.WriteLine("                 ./ydmmd+.      -shdmmmmNmNNNNNNNNdhmNNNNNNNNNmyyyyyyyyyhNNNNNN/                    ");
System.Console.WriteLine("               `+dmmmNNNNds:` `ohdddddhhhhdNNNNNNNhydNNNNNNNNNNmyyyyyyyyyNNNNNNo                    ");
System.Console.WriteLine("              :hhhdmmNNNNNNmdhydddhyyyyyyyhNNNNNNmhyhNNNNNNNNdmmmyyyyyyyyNNNNNNo                    ");
System.Console.WriteLine("            `//.```.+dNNNNNNNdhhyyyyyyyyyhhNNNNNNdhyymNmNNNNNhyyhhyyo/./hNNNNNN-                    ");
System.Console.WriteLine("            .`       .yNNNNNmhhyyyyyhhhhhhhmNNNNmmdy/yNmmNNNNmyyys+-`   yNNNNNy                     ");
System.Console.WriteLine("                      `yNNNNdhyso///ohhhhhhhNNNNmNmh/ymNdhmNNNy/-`     .mNNNms`                     ");
System.Console.WriteLine("                       `+hmmy+-`    -hyys+::NNNNNNmdo:mNmdNNNNy       `hNNmh/                       ");
System.Console.WriteLine("                         `.-`      `--.`    NNNNNmhmh yNdmNNNNm      `ymds:`                        ");
System.Console.WriteLine("                                            mNNNNdmNm`/mhmNNNNN-     /+-`                           ");
System.Console.WriteLine("                                           dNNNNNNNd.`mmdmNNNNs                                     ");
System.Console.WriteLine("                                     ``````.smNNmmNNo``ohNNNNNm+                                    ");
System.Console.WriteLine("                           ````....---::/oymNmdhddmm+::::ddmNNm/-....````                           ");
System.Console.WriteLine("                        ``...---::/++oshmmNmdysooo+///////hmmmmms:---...```                         ");
System.Console.WriteLine("                         ```...-shhhhhhddys+::::::::::::::smhyyddhs..```                            ");
System.Console.WriteLine("                                ```....```...........`````:ddhyo++d/                                ");
System.Console.WriteLine("                   `..`````                                `-/osyys-                                ");
SparringMatch(me,Frank);
System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem2 = System.Console.ReadLine().ToLower();
    
    if(UseItem2 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
         if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }

       }
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();






    System.Console.WriteLine("You notice a wall in front of you with only a path to the left");
    System.Console.WriteLine("You take that path..");
    me.MoveWest();
System.Console.WriteLine("                                             ..--://+++.                                            ");
System.Console.WriteLine("                                             .-:/++osyy`                                            ");
System.Console.WriteLine("                                             ..-/+ossyo                                             ");
System.Console.WriteLine("                                           ``.-:+osyyyo```                                          ");
System.Console.WriteLine("                                          .``..+syhdddy:..                                          ");
System.Console.WriteLine("                                          .`...+osyhhhs:.-                                          ");
System.Console.WriteLine("                                          ....-+ooyyyy+/.-                                          ");
System.Console.WriteLine("                                           ..-/ssyyhhy/:.`                                          ");
System.Console.WriteLine("                                           `..-::/:/ooooo/                                          ");
System.Console.WriteLine("                                         `-:-::+o:+shyss+                                           ");
System.Console.WriteLine("                                        `:///////ooosy+/-                                           ");
System.Console.WriteLine("                                          `-+oo/o+:+hhyys++                                         ");
System.Console.WriteLine("                                         ``.-::://:oo.-+o:                                          ");
System.Console.WriteLine("                                           ``.---:o:`:+o`                                           ");
System.Console.WriteLine("                                               ` -++`+++                                            ");
System.Console.WriteLine("                                                `` .+o`oo/                                          ");
System.Console.WriteLine("                                                ````/o`oo/                                          ");
System.Console.WriteLine("                                                ````:o-+o+                                          ");
System.Console.WriteLine("                                                ````:o:/oo                                          ");
System.Console.WriteLine("                                                ````.-`-+o`                                         ");
System.Console.WriteLine("                                           `    ````````:o-                                         ");
System.Console.WriteLine("                                           `   `````````-++                                         ");
System.Console.WriteLine("                                          .`   ``````..../-                                         ");
System.Console.WriteLine("                                         ``.`....````......`                                        ");
System.Console.WriteLine("                                       `.....`````````..``..``                                      ");
System.Console.WriteLine("                                     ``....``.```.....``````..``                                    ");
System.Console.WriteLine("                                  ``..--::::://::::::::::---.....`                                  ");
System.Console.WriteLine("                                 :++///////////::::::///////:://++/`                                ");
System.Console.WriteLine("                                :syo/:/ooooooo+++/////++ooooosssyys+`                               ");
System.Console.WriteLine("                               -oy+-.-:+++ssyysoo+++++ossyysssyyysso:                               ");
System.Console.WriteLine("                               +oo-.-:/:-:/oyysoooooooosssyysssyyyys+`                              ");
System.Console.WriteLine("                              `+s/..-/:---/syyyyyyyyyyyyyyyyyssssysso-                              ");
System.Console.WriteLine("                              .+s+::/+:--:+hhhhhhhhhhhhhhhhyyyyssssso-                              ");
System.Console.WriteLine("                              .+oo++oo+//+yhddddddddhdddddddyysssssso-                              ");
System.Console.WriteLine("                              .+ooosssyyyyhdmmdddmddmmdmdmdddhyssssoo-                              ");
System.Console.WriteLine("                              `+osssshdddddmmmmmdmmmmmmmmddmdddhsssso-                              ");
System.Console.WriteLine("                              `/oosyhmmmmmmmmmmmmmmmmmmmmmmmmmmdyysso.                              ");
System.Console.WriteLine("                               -+ssydddmmmmmmmmmmmmmmmmmmmmmmmmdhyys+`                              ");
System.Console.WriteLine("                               `/osyddddddmmmmmmmmmmmmmmmmmmmmdddhyo-                               ");
System.Console.WriteLine("                               `./osyddddmmmmmmmmmmmmmmmmmmmmmddhys:``                              ");
System.Console.WriteLine("                               ``./+oyhdddmmmmmmmmmmmmmmmmmmddhhys/-.``                             ");
System.Console.WriteLine("                               ``.-:/osyyhhhddddddddddddddddhdhys+:-.``                             ");
System.Console.WriteLine("                                ``..--:/+osyyhhhdddddddddhhyso+/:--.``                              ");
System.Console.WriteLine("                                  ````.....----:::::::::::----....```                               ");
System.Console.WriteLine("                                     `````````````````````````````                                  ");
 System.Console.WriteLine("In this room you discovered an armor potion! that restore 5 AC. Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No]");
 int pickup2 = Convert.ToInt32(Console.ReadLine());
 if(pickup2 == 1)
    {
       inventory.Add(P2);
       System.Console.WriteLine("You added a armor potion to your inventory");
    }
  if(pickup2 == 2)
  {
     System.Console.WriteLine("You left the potion to itself and continue your journey");

     }
  System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem3 = System.Console.ReadLine().ToLower();
    
    if(UseItem3 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
         if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }

       }   
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();

    System.Console.WriteLine("You notice there is only a single hallway leading up.");
    System.Console.WriteLine("You take that path..");
    me.MoveNorth();
  }
  if(HallWayChoice2 == "left")
  {
    System.Console.WriteLine("You take the path on the left");
    me.MoveWest();
System.Console.WriteLine("In this room you encounter casper, the unfriendly ghost. you have no choice but to fight for your life!");    
System.Console.WriteLine("                                               ```````                                               ");
System.Console.WriteLine("                                           `````       ````                                          ");
System.Console.WriteLine("                                         `.`               ``                                        ");
System.Console.WriteLine("                                       `.`                  `.                                       ");
System.Console.WriteLine("                                      `.                      .                                      ");
System.Console.WriteLine("                                     `.       ````    ```     `.                                     ");
System.Console.WriteLine("                                     .       ``::.` `.::``     .`                                    ");
System.Console.WriteLine("                                    ``        :mmy`  smm+       .                                    ");
System.Console.WriteLine("                                    .        `hmmm- `mmmd.      ``                                   ");
System.Console.WriteLine("                                   `.       .hmmmm- .mmmmd-      .                                   ");
System.Console.WriteLine("                                   .       -dmmmmm. `mmmmmd-     .                                   ");
System.Console.WriteLine("                                   .   .   ymmmmmy   smmmmmd     ``                                  ");
System.Console.WriteLine("                                   .  `.   sddddh-   .hddddy      .                                  ");
System.Console.WriteLine("                       ``` `      .   ``  `./oo/-`   `./oo/.`     .                                  ");
System.Console.WriteLine("                     .`````````   .    .   `...-:------....`      .         `                        ");
System.Console.WriteLine("                    .`        ````.``  -`      smmmmmmm/          .       `.````.                    ");
System.Console.WriteLine("                    .                 `.``     ymmmmmmm+      ``````    ```     .`                   ");
System.Console.WriteLine("                    .```````````````````.``````-mmmmmmd````````````.`````````````.                   ");
System.Console.WriteLine("                    -``.````````````````-```````ymmmmm+```````.`` ````````````.``-                   ");
System.Console.WriteLine("                    -::.````````````````.```````:mmmmm````````-``````````````.:.`:                   ");
System.Console.WriteLine("                     -:.```````````````.````````.mmmmd````````-``````````````-:::/                   ");
System.Console.WriteLine("                      :.````````.````````````````ymmm+````````-`````````````.:/:::                   ");
System.Console.WriteLine("                      ::```````..````````````````./+:`````````-````````````.-:/:-`                   ");
System.Console.WriteLine("                      -::.````.:-````.`````````-``````..``````.`````.``-::::::/                      ");
System.Console.WriteLine("                      `/::---:::-````-``````````:-...-:``.````.`````-``:::::::-                      ");
System.Console.WriteLine("                        `.-:::::-````-```````````-:::-```.`````````.::::::::::`                      ");
System.Console.WriteLine("                           `-::/.````-```````````````````-`````````-/:::/::::-                       ");
System.Console.WriteLine("                             `/:````.-`````````.`````````-`````````::::.                             ");
System.Console.WriteLine("                              :-````-``````````.`````````-````````./::-                              ");
System.Console.WriteLine("                              -`````-`````````.-`````````-.```````-+:-                               ");
System.Console.WriteLine("            `                `-`````-``.```````-`````````.-``````.::`                                ");
System.Console.WriteLine("                             ..```.-...:..`````-`````````.:`````.-:-                                 ");
System.Console.WriteLine("                             -.....-.`.:.......-..........-......::-                                 ");
System.Console.WriteLine("                            ........-..:-......-.........-.......::-                                 ");
System.Console.WriteLine("                            -.......-..-:......-.........-.....-:::-                                 ");
System.Console.WriteLine("                            -::::..-:.../................-....-::::-                                 ");
System.Console.WriteLine("                             -::::-::-..::....................-::::-                                 ");
System.Console.WriteLine("                              ./::::::..:/-................-..-::::-                                 ");
System.Console.WriteLine("                               -:::::::::/:-..........-....:--:::::.                                 ");
System.Console.WriteLine("                                -:::::::::/:-.........:-..-::::-.``                                  ");
System.Console.WriteLine("                                 ::::..::::::-.......-:-.-:/:::                                      ");
System.Console.WriteLine("                                 `.`   `:::::-.......-:--::/:.`                                      ");
System.Console.WriteLine("                                        `:::::-------:::-:/.                                         ");
System.Console.WriteLine("                                         `::::-------::/:::                                          ");
System.Console.WriteLine("                                           ::::-----:::/::.                                          ");
System.Console.WriteLine("                                            -:::----:://:/                                           ");
System.Console.WriteLine("                                             .::::::::/::.                                           ");
System.Console.WriteLine("                                              `::::::::.`                                            ");
System.Console.WriteLine("                                                .::::/`                                              ");
System.Console.WriteLine("                                                  :::-                                               ");
System.Console.WriteLine("                                                   ..                                                ");  
SparringMatch(me,casper);  
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();






    System.Console.WriteLine("You notice a hallway going straight, and another hallway going to your left.");
    System.Console.WriteLine("Which way do you choose to go?");
    System.Console.WriteLine("[Enter up to go straight] or [Enter left to go left]");
    string HallWayChoice3 = System.Console.ReadLine().ToLower();
      if(HallWayChoice3 == "up")
     {
       System.Console.WriteLine("You take the path up");
      me.MoveNorth();
System.Console.WriteLine("                                             ..--://+++.                                            ");
System.Console.WriteLine("                                             .-:/++osyy`                                            ");
System.Console.WriteLine("                                             ..-/+ossyo                                             ");
System.Console.WriteLine("                                           ``.-:+osyyyo```                                          ");
System.Console.WriteLine("                                          .``..+syhdddy:..                                          ");
System.Console.WriteLine("                                          .`...+osyhhhs:.-                                          ");
System.Console.WriteLine("                                          ....-+ooyyyy+/.-                                          ");
System.Console.WriteLine("                                           ..-/ssyyhhy/:.`                                          ");
System.Console.WriteLine("                                           `..-::/:/ooooo/                                          ");
System.Console.WriteLine("                                         `-:-::+o:+shyss+                                           ");
System.Console.WriteLine("                                        `:///////ooosy+/-                                           ");
System.Console.WriteLine("                                          `-+oo/o+:+hhyys++                                         ");
System.Console.WriteLine("                                         ``.-::://:oo.-+o:                                          ");
System.Console.WriteLine("                                           ``.---:o:`:+o`                                           ");
System.Console.WriteLine("                                               ` -++`+++                                            ");
System.Console.WriteLine("                                                `` .+o`oo/                                          ");
System.Console.WriteLine("                                                ````/o`oo/                                          ");
System.Console.WriteLine("                                                ````:o-+o+                                          ");
System.Console.WriteLine("                                                ````:o:/oo                                          ");
System.Console.WriteLine("                                                ````.-`-+o`                                         ");
System.Console.WriteLine("                                           `    ````````:o-                                         ");
System.Console.WriteLine("                                           `   `````````-++                                         ");
System.Console.WriteLine("                                          .`   ``````..../-                                         ");
System.Console.WriteLine("                                         ``.`....````......`                                        ");
System.Console.WriteLine("                                       `.....`````````..``..``                                      ");
System.Console.WriteLine("                                     ``....``.```.....``````..``                                    ");
System.Console.WriteLine("                                  ``..--::::://::::::::::---.....`                                  ");
System.Console.WriteLine("                                 :++///////////::::::///////:://++/`                                ");
System.Console.WriteLine("                                :syo/:/ooooooo+++/////++ooooosssyys+`                               ");
System.Console.WriteLine("                               -oy+-.-:+++ssyysoo+++++ossyysssyyysso:                               ");
System.Console.WriteLine("                               +oo-.-:/:-:/oyysoooooooosssyysssyyyys+`                              ");
System.Console.WriteLine("                              `+s/..-/:---/syyyyyyyyyyyyyyyyyssssysso-                              ");
System.Console.WriteLine("                              .+s+::/+:--:+hhhhhhhhhhhhhhhhyyyyssssso-                              ");
System.Console.WriteLine("                              .+oo++oo+//+yhddddddddhdddddddyysssssso-                              ");
System.Console.WriteLine("                              .+ooosssyyyyhdmmdddmddmmdmdmdddhyssssoo-                              ");
System.Console.WriteLine("                              `+osssshdddddmmmmmdmmmmmmmmddmdddhsssso-                              ");
System.Console.WriteLine("                              `/oosyhmmmmmmmmmmmmmmmmmmmmmmmmmmdyysso.                              ");
System.Console.WriteLine("                               -+ssydddmmmmmmmmmmmmmmmmmmmmmmmmdhyys+`                              ");
System.Console.WriteLine("                               `/osyddddddmmmmmmmmmmmmmmmmmmmmdddhyo-                               ");
System.Console.WriteLine("                               `./osyddddmmmmmmmmmmmmmmmmmmmmmddhys:``                              ");
System.Console.WriteLine("                               ``./+oyhdddmmmmmmmmmmmmmmmmmmddhhys/-.``                             ");
System.Console.WriteLine("                               ``.-:/osyyhhhddddddddddddddddhdhys+:-.``                             ");
System.Console.WriteLine("                                ``..--:/+osyyhhhdddddddddhhyso+/:--.``                              ");
System.Console.WriteLine("                                  ````.....----:::::::::::----....```                               ");
System.Console.WriteLine("                                     `````````````````````````````                                  ");
 System.Console.WriteLine("In this room you discovered an armor potion! Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No");
 int pickup3 = Convert.ToInt32(Console.ReadLine());
 if(pickup3 == 1)
    {
       inventory.Add(P2);
       System.Console.WriteLine("You added a armor potion to your inventory");
    }
  if(pickup3 == 2)
  {
     System.Console.WriteLine("You left the potion to itself and continue your journey");

     }
 System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem4 = System.Console.ReadLine().ToLower();
    
    if(UseItem4 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
         if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }

       }    
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();


      System.Console.WriteLine("You notice there is only a single hallway leading up.");
      System.Console.WriteLine("You take that path..");
      me.MoveNorth();
     }
     if(HallWayChoice3 == "left")
     {
      System.Console.WriteLine("You take the path on the left");
       me.MoveWest();
System.Console.WriteLine("              .ss/.                                                                                 ");
System.Console.WriteLine("            `ohhhhhs/.                                                                              ");
System.Console.WriteLine("           :hddddhhhhho.                                                                            ");
System.Console.WriteLine("          +hdddddddhhy/.                                                                            ");
System.Console.WriteLine("        .yddhhhhhhhhsooo/.                                                                          ");
System.Console.WriteLine("       /ddddhhhhhhhsoossso/`                                                                        ");
System.Console.WriteLine("     .sdddddhhhyyysoooooooo+:`                                                                      ");
System.Console.WriteLine("   `odddddddhhyy+.`-+ooooooo++:`                                                                    ");
System.Console.WriteLine(" .oddddddddhhhy+`    `:+oooo++++:.                                                                  ");
System.Console.WriteLine("-hdddddhhhddhh+         .:+oooo+++/:.                                                               ");
System.Console.WriteLine(" ./yhddhhhhhhs`            .:+oooo+++/:.                                                            ");
System.Console.WriteLine("    ./oyhhhhy.                .:+oooooo+/:.                                                         ");
System.Console.WriteLine("       `.-/+/                    .:+ooooooo+:.`                                                     ");
System.Console.WriteLine("                                    `-/+oooooo+/-`                                                  ");
System.Console.WriteLine("                                       `.:+oooooo+/-.                                               ");
System.Console.WriteLine("                                           `-/oooooo++:.`                                           ");
System.Console.WriteLine("                                              `.:+oooooo+/-`                                        ");
System.Console.WriteLine("                                                  .:+ooooooo+:.`                                    ");
System.Console.WriteLine("                                                    `-/+oooooo+/-`                                  ");
System.Console.WriteLine("                                                        .:+ooossoo+:.                               ");
System.Console.WriteLine("                                                          `-/oossssso/.`                            ");
System.Console.WriteLine("                                                             `.:+ossssso/-`                         ");
System.Console.WriteLine("                                                                 `:+ossssoo/-`                      ");
System.Console.WriteLine("                                                                    `-/oosssoo/-`                   ");
System.Console.WriteLine("                                                                        `./osssoo+/.`               ");
System.Console.WriteLine("                                                                            `./ossooo+:.            ");
System.Console.WriteLine("                                                                               `-/osssoo+:`         ");
System.Console.WriteLine("                                                                                  `-+ssssoo+-`      ");
System.Console.WriteLine("                                                                                     .:ossssoo/.    ");
System.Console.WriteLine("                                                                                       `:ssssssso:` ");
System.Console.WriteLine("                                                                                         .osss+ysss:");
System.Console.WriteLine("                                                                                         `+yyyysso` ");
System.Console.WriteLine("                                                                                            -+oo:.  ");
 System.Console.WriteLine("In this room you discovered an Axe! Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No]");
 int pickup4 = Convert.ToInt32(Console.ReadLine());
 if(pickup4 == 1)
    {
       inventory.Add(P3);
       System.Console.WriteLine("You added an axe to your inventory");
    }
  if(pickup4 == 2)
    {
      System.Console.WriteLine("You left the axe to itself and continue your journey");

      }
System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem5 = System.Console.ReadLine().ToLower();
    
    if(UseItem5 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
         if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }

       }      
 System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();


      System.Console.WriteLine("You notice there is only a single hallway leading to the right.");
      System.Console.WriteLine("You take that path..");
      me.MoveEast();
System.Console.WriteLine("                                             ..--://+++.                                            ");
System.Console.WriteLine("                                             .-:/++osyy`                                            ");
System.Console.WriteLine("                                             ..-/+ossyo                                             ");
System.Console.WriteLine("                                           ``.-:+osyyyo```                                          ");
System.Console.WriteLine("                                          .``..+syhdddy:..                                          ");
System.Console.WriteLine("                                          .`...+osyhhhs:.-                                          ");
System.Console.WriteLine("                                          ....-+ooyyyy+/.-                                          ");
System.Console.WriteLine("                                           ..-/ssyyhhy/:.`                                          ");
System.Console.WriteLine("                                           `..-::/:/ooooo/                                          ");
System.Console.WriteLine("                                         `-:-::+o:+shyss+                                           ");
System.Console.WriteLine("                                        `:///////ooosy+/-                                           ");
System.Console.WriteLine("                                          `-+oo/o+:+hhyys++                                         ");
System.Console.WriteLine("                                         ``.-::://:oo.-+o:                                          ");
System.Console.WriteLine("                                           ``.---:o:`:+o`                                           ");
System.Console.WriteLine("                                               ` -++`+++                                            ");
System.Console.WriteLine("                                                `` .+o`oo/                                          ");
System.Console.WriteLine("                                                ````/o`oo/                                          ");
System.Console.WriteLine("                                                ````:o-+o+                                          ");
System.Console.WriteLine("                                                ````:o:/oo                                          ");
System.Console.WriteLine("                                                ````.-`-+o`                                         ");
System.Console.WriteLine("                                           `    ````````:o-                                         ");
System.Console.WriteLine("                                           `   `````````-++                                         ");
System.Console.WriteLine("                                          .`   ``````..../-                                         ");
System.Console.WriteLine("                                         ``.`....````......`                                        ");
System.Console.WriteLine("                                       `.....`````````..``..``                                      ");
System.Console.WriteLine("                                     ``....``.```.....``````..``                                    ");
System.Console.WriteLine("                                  ``..--::::://::::::::::---.....`                                  ");
System.Console.WriteLine("                                 :++///////////::::::///////:://++/`                                ");
System.Console.WriteLine("                                :syo/:/ooooooo+++/////++ooooosssyys+`                               ");
System.Console.WriteLine("                               -oy+-.-:+++ssyysoo+++++ossyysssyyysso:                               ");
System.Console.WriteLine("                               +oo-.-:/:-:/oyysoooooooosssyysssyyyys+`                              ");
System.Console.WriteLine("                              `+s/..-/:---/syyyyyyyyyyyyyyyyyssssysso-                              ");
System.Console.WriteLine("                              .+s+::/+:--:+hhhhhhhhhhhhhhhhyyyyssssso-                              ");
System.Console.WriteLine("                              .+oo++oo+//+yhddddddddhdddddddyysssssso-                              ");
System.Console.WriteLine("                              .+ooosssyyyyhdmmdddmddmmdmdmdddhyssssoo-                              ");
System.Console.WriteLine("                              `+osssshdddddmmmmmdmmmmmmmmddmdddhsssso-                              ");
System.Console.WriteLine("                              `/oosyhmmmmmmmmmmmmmmmmmmmmmmmmmmdyysso.                              ");
System.Console.WriteLine("                               -+ssydddmmmmmmmmmmmmmmmmmmmmmmmmdhyys+`                              ");
System.Console.WriteLine("                               `/osyddddddmmmmmmmmmmmmmmmmmmmmdddhyo-                               ");
System.Console.WriteLine("                               `./osyddddmmmmmmmmmmmmmmmmmmmmmddhys:``                              ");
System.Console.WriteLine("                               ``./+oyhdddmmmmmmmmmmmmmmmmmmddhhys/-.``                             ");
System.Console.WriteLine("                               ``.-:/osyyhhhddddddddddddddddhdhys+:-.``                             ");
System.Console.WriteLine("                                ``..--:/+osyyhhhdddddddddhhyso+/:--.``                              ");
System.Console.WriteLine("                                  ````.....----:::::::::::----....```                               ");
System.Console.WriteLine("                                     `````````````````````````````                                  ");
 System.Console.WriteLine("In this room you discovered an armor potion! Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No]");
 int pickup5 = Convert.ToInt32(Console.ReadLine());
 if(pickup5 == 1)
    {
       inventory.Add(P2);
       System.Console.WriteLine("You added a armor potion to your inventory");
    }
  if(pickup5 == 2)
  {
     System.Console.WriteLine("You left the potion to itself and continue your journey");

     }
System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem6 = System.Console.ReadLine().ToLower();
    
    if(UseItem6 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
         if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }

       }     
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();

      System.Console.WriteLine("You notice there is only a single hallway leading up.");
      System.Console.WriteLine("You take that path..");
       me.MoveNorth();
     }

  }

}


if (HallWayChoice == "left")
{
  System.Console.WriteLine("You go left.");
  me.MoveWest();
  System.Console.WriteLine("You notice a hallway going straight, and another hallway going to your left.");
  System.Console.WriteLine("Which way do you choose to go?");
  System.Console.WriteLine("[Enter up to go straight] or [Enter left to go left]"); 
   string HallWayChoice4 = System.Console.ReadLine().ToLower();

  if(HallWayChoice4 == "up")
  {
    System.Console.WriteLine("You go up.");
    me.MoveNorth();
System.Console.WriteLine("In this room you encounter casper, the unfriendly ghost. you have no choice but to fight for your life!");    
System.Console.WriteLine("                                               ```````                                               ");
System.Console.WriteLine("                                           `````       ````                                          ");
System.Console.WriteLine("                                         `.`               ``                                        ");
System.Console.WriteLine("                                       `.`                  `.                                       ");
System.Console.WriteLine("                                      `.                      .                                      ");
System.Console.WriteLine("                                     `.       ````    ```     `.                                     ");
System.Console.WriteLine("                                     .       ``::.` `.::``     .`                                    ");
System.Console.WriteLine("                                    ``        :mmy`  smm+       .                                    ");
System.Console.WriteLine("                                    .        `hmmm- `mmmd.      ``                                   ");
System.Console.WriteLine("                                   `.       .hmmmm- .mmmmd-      .                                   ");
System.Console.WriteLine("                                   .       -dmmmmm. `mmmmmd-     .                                   ");
System.Console.WriteLine("                                   .   .   ymmmmmy   smmmmmd     ``                                  ");
System.Console.WriteLine("                                   .  `.   sddddh-   .hddddy      .                                  ");
System.Console.WriteLine("                       ``` `      .   ``  `./oo/-`   `./oo/.`     .                                  ");
System.Console.WriteLine("                     .`````````   .    .   `...-:------....`      .         `                        ");
System.Console.WriteLine("                    .`        ````.``  -`      smmmmmmm/          .       `.````.                    ");
System.Console.WriteLine("                    .                 `.``     ymmmmmmm+      ``````    ```     .`                   ");
System.Console.WriteLine("                    .```````````````````.``````-mmmmmmd````````````.`````````````.                   ");
System.Console.WriteLine("                    -``.````````````````-```````ymmmmm+```````.`` ````````````.``-                   ");
System.Console.WriteLine("                    -::.````````````````.```````:mmmmm````````-``````````````.:.`:                   ");
System.Console.WriteLine("                     -:.```````````````.````````.mmmmd````````-``````````````-:::/                   ");
System.Console.WriteLine("                      :.````````.````````````````ymmm+````````-`````````````.:/:::                   ");
System.Console.WriteLine("                      ::```````..````````````````./+:`````````-````````````.-:/:-`                   ");
System.Console.WriteLine("                      -::.````.:-````.`````````-``````..``````.`````.``-::::::/                      ");
System.Console.WriteLine("                      `/::---:::-````-``````````:-...-:``.````.`````-``:::::::-                      ");
System.Console.WriteLine("                        `.-:::::-````-```````````-:::-```.`````````.::::::::::`                      ");
System.Console.WriteLine("                           `-::/.````-```````````````````-`````````-/:::/::::-                       ");
System.Console.WriteLine("                             `/:````.-`````````.`````````-`````````::::.                             ");
System.Console.WriteLine("                              :-````-``````````.`````````-````````./::-                              ");
System.Console.WriteLine("                              -`````-`````````.-`````````-.```````-+:-                               ");
System.Console.WriteLine("            `                `-`````-``.```````-`````````.-``````.::`                                ");
System.Console.WriteLine("                             ..```.-...:..`````-`````````.:`````.-:-                                 ");
System.Console.WriteLine("                             -.....-.`.:.......-..........-......::-                                 ");
System.Console.WriteLine("                            ........-..:-......-.........-.......::-                                 ");
System.Console.WriteLine("                            -.......-..-:......-.........-.....-:::-                                 ");
System.Console.WriteLine("                            -::::..-:.../................-....-::::-                                 ");
System.Console.WriteLine("                             -::::-::-..::....................-::::-                                 ");
System.Console.WriteLine("                              ./::::::..:/-................-..-::::-                                 ");
System.Console.WriteLine("                               -:::::::::/:-..........-....:--:::::.                                 ");
System.Console.WriteLine("                                -:::::::::/:-.........:-..-::::-.``                                  ");
System.Console.WriteLine("                                 ::::..::::::-.......-:-.-:/:::                                      ");
System.Console.WriteLine("                                 `.`   `:::::-.......-:--::/:.`                                      ");
System.Console.WriteLine("                                        `:::::-------:::-:/.                                         ");
System.Console.WriteLine("                                         `::::-------::/:::                                          ");
System.Console.WriteLine("                                           ::::-----:::/::.                                          ");
System.Console.WriteLine("                                            -:::----:://:/                                           ");
System.Console.WriteLine("                                             .::::::::/::.                                           ");
System.Console.WriteLine("                                              `::::::::.`                                            ");
System.Console.WriteLine("                                                .::::/`                                              ");
System.Console.WriteLine("                                                  :::-                                               ");
System.Console.WriteLine("                                                   ..                                                "); 
SparringMatch(me,casper); 
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();





    System.Console.WriteLine("You notice a hallway going left, and another hallway going to your right.");
    System.Console.WriteLine("Which way do you choose to go?");
    System.Console.WriteLine("[Enter right to go right] or [Enter left to go left]");
    string HallWayChoice5 = System.Console.ReadLine().ToLower();
    if(HallWayChoice5 == "left")
    {
        System.Console.WriteLine("You go left.");
        me.MoveWest();
System.Console.WriteLine("              .ss/.                                                                                 ");
System.Console.WriteLine("            `ohhhhhs/.                                                                              ");
System.Console.WriteLine("           :hddddhhhhho.                                                                            ");
System.Console.WriteLine("          +hdddddddhhy/.                                                                            ");
System.Console.WriteLine("        .yddhhhhhhhhsooo/.                                                                          ");
System.Console.WriteLine("       /ddddhhhhhhhsoossso/`                                                                        ");
System.Console.WriteLine("     .sdddddhhhyyysoooooooo+:`                                                                      ");
System.Console.WriteLine("   `odddddddhhyy+.`-+ooooooo++:`                                                                    ");
System.Console.WriteLine(" .oddddddddhhhy+`    `:+oooo++++:.                                                                  ");
System.Console.WriteLine("-hdddddhhhddhh+         .:+oooo+++/:.                                                               ");
System.Console.WriteLine(" ./yhddhhhhhhs`            .:+oooo+++/:.                                                            ");
System.Console.WriteLine("    ./oyhhhhy.                .:+oooooo+/:.                                                         ");
System.Console.WriteLine("       `.-/+/                    .:+ooooooo+:.`                                                     ");
System.Console.WriteLine("                                    `-/+oooooo+/-`                                                  ");
System.Console.WriteLine("                                       `.:+oooooo+/-.                                               ");
System.Console.WriteLine("                                           `-/oooooo++:.`                                           ");
System.Console.WriteLine("                                              `.:+oooooo+/-`                                        ");
System.Console.WriteLine("                                                  .:+ooooooo+:.`                                    ");
System.Console.WriteLine("                                                    `-/+oooooo+/-`                                  ");
System.Console.WriteLine("                                                        .:+ooossoo+:.                               ");
System.Console.WriteLine("                                                          `-/oossssso/.`                            ");
System.Console.WriteLine("                                                             `.:+ossssso/-`                         ");
System.Console.WriteLine("                                                                 `:+ossssoo/-`                      ");
System.Console.WriteLine("                                                                    `-/oosssoo/-`                   ");
System.Console.WriteLine("                                                                        `./osssoo+/.`               ");
System.Console.WriteLine("                                                                            `./ossooo+:.            ");
System.Console.WriteLine("                                                                               `-/osssoo+:`         ");
System.Console.WriteLine("                                                                                  `-+ssssoo+-`      ");
System.Console.WriteLine("                                                                                     .:ossssoo/.    ");
System.Console.WriteLine("                                                                                       `:ssssssso:` ");
System.Console.WriteLine("                                                                                         .osss+ysss:");
System.Console.WriteLine("                                                                                         `+yyyysso` ");
System.Console.WriteLine("                                                                                            -+oo:.  ");
 System.Console.WriteLine("In this room you discovered a Axe! Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No]");
 int pickup6 = Convert.ToInt32(Console.ReadLine());
 if(pickup6 == 1)
    {
       inventory.Add(P3);
       System.Console.WriteLine("You added an axe to your inventory");
    }
  if(pickup6 == 2)
    {
      System.Console.WriteLine("You left the axe to itself and continue your journey");

      }
System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem7 = System.Console.ReadLine().ToLower();
    
    if(UseItem7 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
     if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }
       }      
 System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();

        System.Console.WriteLine("You notice there is only a single hallway leading up.");
        System.Console.WriteLine("You take that path..");
        me.MoveNorth();
        System.Console.WriteLine("You notice there is only a single hallway leading right.");
        System.Console.WriteLine("You take that path..");
        me.MoveEast();
System.Console.WriteLine("                                             ..--://+++.                                            ");
System.Console.WriteLine("                                             .-:/++osyy`                                            ");
System.Console.WriteLine("                                             ..-/+ossyo                                             ");
System.Console.WriteLine("                                           ``.-:+osyyyo```                                          ");
System.Console.WriteLine("                                          .``..+syhdddy:..                                          ");
System.Console.WriteLine("                                          .`...+osyhhhs:.-                                          ");
System.Console.WriteLine("                                          ....-+ooyyyy+/.-                                          ");
System.Console.WriteLine("                                           ..-/ssyyhhy/:.`                                          ");
System.Console.WriteLine("                                           `..-::/:/ooooo/                                          ");
System.Console.WriteLine("                                         `-:-::+o:+shyss+                                           ");
System.Console.WriteLine("                                        `:///////ooosy+/-                                           ");
System.Console.WriteLine("                                          `-+oo/o+:+hhyys++                                         ");
System.Console.WriteLine("                                         ``.-::://:oo.-+o:                                          ");
System.Console.WriteLine("                                           ``.---:o:`:+o`                                           ");
System.Console.WriteLine("                                               ` -++`+++                                            ");
System.Console.WriteLine("                                                `` .+o`oo/                                          ");
System.Console.WriteLine("                                                ````/o`oo/                                          ");
System.Console.WriteLine("                                                ````:o-+o+                                          ");
System.Console.WriteLine("                                                ````:o:/oo                                          ");
System.Console.WriteLine("                                                ````.-`-+o`                                         ");
System.Console.WriteLine("                                           `    ````````:o-                                         ");
System.Console.WriteLine("                                           `   `````````-++                                         ");
System.Console.WriteLine("                                          .`   ``````..../-                                         ");
System.Console.WriteLine("                                         ``.`....````......`                                        ");
System.Console.WriteLine("                                       `.....`````````..``..``                                      ");
System.Console.WriteLine("                                     ``....``.```.....``````..``                                    ");
System.Console.WriteLine("                                  ``..--::::://::::::::::---.....`                                  ");
System.Console.WriteLine("                                 :++///////////::::::///////:://++/`                                ");
System.Console.WriteLine("                                :syo/:/ooooooo+++/////++ooooosssyys+`                               ");
System.Console.WriteLine("                               -oy+-.-:+++ssyysoo+++++ossyysssyyysso:                               ");
System.Console.WriteLine("                               +oo-.-:/:-:/oyysoooooooosssyysssyyyys+`                              ");
System.Console.WriteLine("                              `+s/..-/:---/syyyyyyyyyyyyyyyyyssssysso-                              ");
System.Console.WriteLine("                              .+s+::/+:--:+hhhhhhhhhhhhhhhhyyyyssssso-                              ");
System.Console.WriteLine("                              .+oo++oo+//+yhddddddddhdddddddyysssssso-                              ");
System.Console.WriteLine("                              .+ooosssyyyyhdmmdddmddmmdmdmdddhyssssoo-                              ");
System.Console.WriteLine("                              `+osssshdddddmmmmmdmmmmmmmmddmdddhsssso-                              ");
System.Console.WriteLine("                              `/oosyhmmmmmmmmmmmmmmmmmmmmmmmmmmdyysso.                              ");
System.Console.WriteLine("                               -+ssydddmmmmmmmmmmmmmmmmmmmmmmmmdhyys+`                              ");
System.Console.WriteLine("                               `/osyddddddmmmmmmmmmmmmmmmmmmmmdddhyo-                               ");
System.Console.WriteLine("                               `./osyddddmmmmmmmmmmmmmmmmmmmmmddhys:``                              ");
System.Console.WriteLine("                               ``./+oyhdddmmmmmmmmmmmmmmmmmmddhhys/-.``                             ");
System.Console.WriteLine("                               ``.-:/osyyhhhddddddddddddddddhdhys+:-.``                             ");
System.Console.WriteLine("                                ``..--:/+osyyhhhdddddddddhhyso+/:--.``                              ");
System.Console.WriteLine("                                  ````.....----:::::::::::----....```                               ");
System.Console.WriteLine("                                     `````````````````````````````                                  ");
 System.Console.WriteLine("In this room you discovered an armor potion! Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No]");
 int pickup7 = Convert.ToInt32(Console.ReadLine());
 if(pickup7 == 1)
    {
       inventory.Add(P2);
       System.Console.WriteLine("You added a armor potion to your inventory");
    }
  if(pickup7 == 2)
  {
     System.Console.WriteLine("You left the potion to itself and continue your journey");

     }
System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem8 = System.Console.ReadLine().ToLower();
    
    if(UseItem8 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
     if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }
       }     
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();


        System.Console.WriteLine("You notice there is only a single hallway leading up.");
        System.Console.WriteLine("You take that path..");
        me.MoveNorth();
    }
    if(HallWayChoice5 == "right")
    {
        System.Console.WriteLine("You go right.");
        me.MoveEast();
System.Console.WriteLine("                                             ..--://+++.                                            ");
System.Console.WriteLine("                                             .-:/++osyy`                                            ");
System.Console.WriteLine("                                             ..-/+ossyo                                             ");
System.Console.WriteLine("                                           ``.-:+osyyyo```                                          ");
System.Console.WriteLine("                                          .``..+syhdddy:..                                          ");
System.Console.WriteLine("                                          .`...+osyhhhs:.-                                          ");
System.Console.WriteLine("                                          ....-+ooyyyy+/.-                                          ");
System.Console.WriteLine("                                           ..-/ssyyhhy/:.`                                          ");
System.Console.WriteLine("                                           `..-::/:/ooooo/                                          ");
System.Console.WriteLine("                                         `-:-::+o:+shyss+                                           ");
System.Console.WriteLine("                                        `:///////ooosy+/-                                           ");
System.Console.WriteLine("                                          `-+oo/o+:+hhyys++                                         ");
System.Console.WriteLine("                                         ``.-::://:oo.-+o:                                          ");
System.Console.WriteLine("                                           ``.---:o:`:+o`                                           ");
System.Console.WriteLine("                                               ` -++`+++                                            ");
System.Console.WriteLine("                                                `` .+o`oo/                                          ");
System.Console.WriteLine("                                                ````/o`oo/                                          ");
System.Console.WriteLine("                                                ````:o-+o+                                          ");
System.Console.WriteLine("                                                ````:o:/oo                                          ");
System.Console.WriteLine("                                                ````.-`-+o`                                         ");
System.Console.WriteLine("                                           `    ````````:o-                                         ");
System.Console.WriteLine("                                           `   `````````-++                                         ");
System.Console.WriteLine("                                          .`   ``````..../-                                         ");
System.Console.WriteLine("                                         ``.`....````......`                                        ");
System.Console.WriteLine("                                       `.....`````````..``..``                                      ");
System.Console.WriteLine("                                     ``....``.```.....``````..``                                    ");
System.Console.WriteLine("                                  ``..--::::://::::::::::---.....`                                  ");
System.Console.WriteLine("                                 :++///////////::::::///////:://++/`                                ");
System.Console.WriteLine("                                :syo/:/ooooooo+++/////++ooooosssyys+`                               ");
System.Console.WriteLine("                               -oy+-.-:+++ssyysoo+++++ossyysssyyysso:                               ");
System.Console.WriteLine("                               +oo-.-:/:-:/oyysoooooooosssyysssyyyys+`                              ");
System.Console.WriteLine("                              `+s/..-/:---/syyyyyyyyyyyyyyyyyssssysso-                              ");
System.Console.WriteLine("                              .+s+::/+:--:+hhhhhhhhhhhhhhhhyyyyssssso-                              ");
System.Console.WriteLine("                              .+oo++oo+//+yhddddddddhdddddddyysssssso-                              ");
System.Console.WriteLine("                              .+ooosssyyyyhdmmdddmddmmdmdmdddhyssssoo-                              ");
System.Console.WriteLine("                              `+osssshdddddmmmmmdmmmmmmmmddmdddhsssso-                              ");
System.Console.WriteLine("                              `/oosyhmmmmmmmmmmmmmmmmmmmmmmmmmmdyysso.                              ");
System.Console.WriteLine("                               -+ssydddmmmmmmmmmmmmmmmmmmmmmmmmdhyys+`                              ");
System.Console.WriteLine("                               `/osyddddddmmmmmmmmmmmmmmmmmmmmdddhyo-                               ");
System.Console.WriteLine("                               `./osyddddmmmmmmmmmmmmmmmmmmmmmddhys:``                              ");
System.Console.WriteLine("                               ``./+oyhdddmmmmmmmmmmmmmmmmmmddhhys/-.``                             ");
System.Console.WriteLine("                               ``.-:/osyyhhhddddddddddddddddhdhys+:-.``                             ");
System.Console.WriteLine("                                ``..--:/+osyyhhhdddddddddhhyso+/:--.``                              ");
System.Console.WriteLine("                                  ````.....----:::::::::::----....```                               ");
System.Console.WriteLine("                                     `````````````````````````````                                  ");
 System.Console.WriteLine("In this room you discovered a potion of healing that heals for 25hp. Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No]");
 int pickup8 = Convert.ToInt32(Console.ReadLine());
 if(pickup8 == 1)
    {
       inventory.Add(P1);
       System.Console.WriteLine("You added a healing potion to your inventory");
    }
  if(pickup8 ==2)
    {
      System.Console.WriteLine("You left the potion to itself and continue your journey");

      }
 System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem9 = System.Console.ReadLine().ToLower();
    
    if(UseItem9 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
         if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }

       }     
 System.Console.WriteLine("Press any key to continue..."); 
 Console.ReadKey(); 
 System.Console.Clear();

        System.Console.WriteLine("You notice there is only a single hallway leading up.");
        System.Console.WriteLine("You take that path..");
        me.MoveNorth();
System.Console.WriteLine("In this room you encounter a vampire, you have no choice but to fight for your life!");        
System.Console.WriteLine("                                                -/oyhdddhys/.                                       ");
System.Console.WriteLine("                                             `+dmNmmmNNNNNNNm+                                      ");
System.Console.WriteLine("                                            /dmdysooyyyyhmNNNm+                                     ");
System.Console.WriteLine("                                           :ho:--:+so/:--:+shmm+                                    ");
System.Console.WriteLine("                                          `y+:...--:------:/oymd                                    ");
System.Console.WriteLine("                                        .`-o:oyo/-.--.:/+ss//hmd                                    ");
System.Console.WriteLine("                                       `:::::/+oho/:/osyy+///mNo`..                                 ");
System.Console.WriteLine("                                        ://-:-:::--./-:///::/sh:::.                                 ");
System.Console.WriteLine("                                        -/::------../:-.---:/+o//-                                  ");
System.Console.WriteLine("                                     /`  .-///:---::+:---////++:-` :.                               ");
System.Console.WriteLine("                                     dd+. `://s.:::::::-yo////.`  `dy                               ");
System.Console.WriteLine("                              ```` ` /NNmy+/::/+hhysyy/o+:://- `-/yNy                               ");
System.Console.WriteLine("                           ..-:+/.``` omNNNm+::/yyyysso/::/+ssydmmmm-                               ");
System.Console.WriteLine("                          . .:+s+-../  +mNNNmo::::::/::::/odNNNNNmd:     ``                         ");
System.Console.WriteLine("                         `.`.-//:://:   -ymNNms:::::::::/+mmNNNmho.     `::```                      ");
System.Console.WriteLine("                         .::/ossyyho/     :dmmh`-::::--/osNmmmm+.`..   .-:-:::`                     ");
System.Console.WriteLine("                          .:/oosssy+`    .ymN++` ````.oo:hNNdmdy. .--.---::/:-                      ");
System.Console.WriteLine("                           .::::+++`     odmd``.:`.--.:-:mddddNdd/ -::::::/:/-                      ");
System.Console.WriteLine("                            .::-++/`.    hmm:  ./.:+-..-oNNddNNNmmo`::::::/::.                      ");
System.Console.WriteLine("                             .:.++./my/.-dm/  ..-..-``..hNdmNmNNmmmy`-///:-`                        ");
System.Console.WriteLine("                               .+-/dNNNNmdo  `.-.--.....mdmNmymmmdmNs:-:`                           ");
System.Console.WriteLine("                            `.://:odmNNNNd`    `. ```...smNNhyymmmNNNmh:                            ");
System.Console.WriteLine("                            ......` -+ymm+`   `.`  ``...:dNmyyyymNNNNNNm-                           ");
System.Console.WriteLine("                                       sd/`   :s/` ```..-omNhyyyyhdhmNNNm/                          ");
System.Console.WriteLine("                                       yhNy-+dNNNm+``./sdNdNmyyyyyyyhmNNNN/                         ");
System.Console.WriteLine("                                       odNNmNNNNNNNddmmNNNmmNhyyyyyyyhNNNNN/                        ");
System.Console.WriteLine("                                       .mNNNNNNNNNNNNNNNNNNdNdyyyyyyyhdNNNNm/                       ");
System.Console.WriteLine("                                        hNNNNNNNNNNNNNNNNNNNmmyyyyyyyhymNNNNm-                      ");
System.Console.WriteLine("                                        /NNNNNNNNNNNNNNNNNNNmmyyyyyyyhyhNNNNNd`                     ");
System.Console.WriteLine("                                       `-mNNmmmmmddddmNNNNNNNmyyyyyyyhyymNNNNNs                     ");
System.Console.WriteLine("                    `-.`          .:oyddmNNNNNNNNNddmmNNNNNNNNhyyyyyyyyyhNNNNNm.                    ");
System.Console.WriteLine("                 ./ydmmd+.      -shdmmmmNmNNNNNNNNdhmNNNNNNNNNmyyyyyyyyyhNNNNNN/                    ");
System.Console.WriteLine("               `+dmmmNNNNds:` `ohdddddhhhhdNNNNNNNhydNNNNNNNNNNmyyyyyyyyyNNNNNNo                    ");
System.Console.WriteLine("              :hhhdmmNNNNNNmdhydddhyyyyyyyhNNNNNNmhyhNNNNNNNNdmmmyyyyyyyyNNNNNNo                    ");
System.Console.WriteLine("            `//.```.+dNNNNNNNdhhyyyyyyyyyhhNNNNNNdhyymNmNNNNNhyyhhyyo/./hNNNNNN-                    ");
System.Console.WriteLine("            .`       .yNNNNNmhhyyyyyhhhhhhhmNNNNmmdy/yNmmNNNNmyyys+-`   yNNNNNy                     ");
System.Console.WriteLine("                      `yNNNNdhyso///ohhhhhhhNNNNmNmh/ymNdhmNNNy/-`     .mNNNms`                     ");
System.Console.WriteLine("                       `+hmmy+-`    -hyys+::NNNNNNmdo:mNmdNNNNy       `hNNmh/                       ");
System.Console.WriteLine("                         `.-`      `--.`    NNNNNmhmh yNdmNNNNm      `ymds:`                        ");
System.Console.WriteLine("                                            mNNNNdmNm`/mhmNNNNN-     /+-`                           ");
System.Console.WriteLine("                                           dNNNNNNNd.`mmdmNNNNs                                     ");
System.Console.WriteLine("                                     ``````.smNNmmNNo``ohNNNNNm+                                    ");
System.Console.WriteLine("                           ````....---::/oymNmdhddmm+::::ddmNNm/-....````                           ");
System.Console.WriteLine("                        ``...---::/++oshmmNmdysooo+///////hmmmmms:---...```                         ");
System.Console.WriteLine("                         ```...-shhhhhhddys+::::::::::::::smhyyddhs..```                            ");
System.Console.WriteLine("                                ```....```...........`````:ddhyo++d/                                ");
System.Console.WriteLine("                   `..`````                                `-/osyys-                                "); 
SparringMatch(me,Frank); 
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();





System.Console.WriteLine("You notice there is only a single hallway leading left.");
System.Console.WriteLine("You take that path..");
me.MoveWest();
System.Console.WriteLine("                                             ..--://+++.                                            ");
System.Console.WriteLine("                                             .-:/++osyy`                                            ");
System.Console.WriteLine("                                             ..-/+ossyo                                             ");
System.Console.WriteLine("                                           ``.-:+osyyyo```                                          ");
System.Console.WriteLine("                                          .``..+syhdddy:..                                          ");
System.Console.WriteLine("                                          .`...+osyhhhs:.-                                          ");
System.Console.WriteLine("                                          ....-+ooyyyy+/.-                                          ");
System.Console.WriteLine("                                           ..-/ssyyhhy/:.`                                          ");
System.Console.WriteLine("                                           `..-::/:/ooooo/                                          ");
System.Console.WriteLine("                                         `-:-::+o:+shyss+                                           ");
System.Console.WriteLine("                                        `:///////ooosy+/-                                           ");
System.Console.WriteLine("                                          `-+oo/o+:+hhyys++                                         ");
System.Console.WriteLine("                                         ``.-::://:oo.-+o:                                          ");
System.Console.WriteLine("                                           ``.---:o:`:+o`                                           ");
System.Console.WriteLine("                                               ` -++`+++                                            ");
System.Console.WriteLine("                                                `` .+o`oo/                                          ");
System.Console.WriteLine("                                                ````/o`oo/                                          ");
System.Console.WriteLine("                                                ````:o-+o+                                          ");
System.Console.WriteLine("                                                ````:o:/oo                                          ");
System.Console.WriteLine("                                                ````.-`-+o`                                         ");
System.Console.WriteLine("                                           `    ````````:o-                                         ");
System.Console.WriteLine("                                           `   `````````-++                                         ");
System.Console.WriteLine("                                          .`   ``````..../-                                         ");
System.Console.WriteLine("                                         ``.`....````......`                                        ");
System.Console.WriteLine("                                       `.....`````````..``..``                                      ");
System.Console.WriteLine("                                     ``....``.```.....``````..``                                    ");
System.Console.WriteLine("                                  ``..--::::://::::::::::---.....`                                  ");
System.Console.WriteLine("                                 :++///////////::::::///////:://++/`                                ");
System.Console.WriteLine("                                :syo/:/ooooooo+++/////++ooooosssyys+`                               ");
System.Console.WriteLine("                               -oy+-.-:+++ssyysoo+++++ossyysssyyysso:                               ");
System.Console.WriteLine("                               +oo-.-:/:-:/oyysoooooooosssyysssyyyys+`                              ");
System.Console.WriteLine("                              `+s/..-/:---/syyyyyyyyyyyyyyyyyssssysso-                              ");
System.Console.WriteLine("                              .+s+::/+:--:+hhhhhhhhhhhhhhhhyyyyssssso-                              ");
System.Console.WriteLine("                              .+oo++oo+//+yhddddddddhdddddddyysssssso-                              ");
System.Console.WriteLine("                              .+ooosssyyyyhdmmdddmddmmdmdmdddhyssssoo-                              ");
System.Console.WriteLine("                              `+osssshdddddmmmmmdmmmmmmmmddmdddhsssso-                              ");
System.Console.WriteLine("                              `/oosyhmmmmmmmmmmmmmmmmmmmmmmmmmmdyysso.                              ");
System.Console.WriteLine("                               -+ssydddmmmmmmmmmmmmmmmmmmmmmmmmdhyys+`                              ");
System.Console.WriteLine("                               `/osyddddddmmmmmmmmmmmmmmmmmmmmdddhyo-                               ");
System.Console.WriteLine("                               `./osyddddmmmmmmmmmmmmmmmmmmmmmddhys:``                              ");
System.Console.WriteLine("                               ``./+oyhdddmmmmmmmmmmmmmmmmmmddhhys/-.``                             ");
System.Console.WriteLine("                               ``.-:/osyyhhhddddddddddddddddhdhys+:-.``                             ");
System.Console.WriteLine("                                ``..--:/+osyyhhhdddddddddhhyso+/:--.``                              ");
System.Console.WriteLine("                                  ````.....----:::::::::::----....```                               ");
System.Console.WriteLine("                                     `````````````````````````````                                  ");
 System.Console.WriteLine("In this room you discovered an armor potion! Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No");
 int pickup9 = Convert.ToInt32(Console.ReadLine());
 if(pickup9 == 1)
    {
       inventory.Add(P2);
       System.Console.WriteLine("You added a armor potion to your inventory");
    }
  if(pickup9 == 2)
  {
     System.Console.WriteLine("You left the potion to itself and continue your journey");

     }
     System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem10 = System.Console.ReadLine().ToLower();
    
    if(UseItem10 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
     if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }
       }
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();



        System.Console.WriteLine("You notice there is only a single hallway leading up.");
        System.Console.WriteLine("You take that path..");
        me.MoveNorth();
    }


  }
  if(HallWayChoice4 == "left")
  {
    System.Console.WriteLine("You go left.");
    me.MoveWest();
System.Console.WriteLine("In this room you encounter jack the skeleton, you have no choice but to fight for your life!");    
System.Console.WriteLine("                                           `.::::::::-`                                              ");
System.Console.WriteLine("                                        .//:-``    ``.-///-                                          ");
System.Console.WriteLine("                                       -/-`               `-//`                                      ");
System.Console.WriteLine("                                      /:`                    .+:                                     ");
System.Console.WriteLine("                                    `+-                        //                                    ");
System.Console.WriteLine("                                    ::   `-::::-`    `--::::`   +-                                   ");
System.Console.WriteLine("                                    o    ``./oo:`     -+o+-``   .o                                   ");
System.Console.WriteLine("                                    o     :mMMMNh`   oNMMMN+    `o                                   ");
System.Console.WriteLine("                                    o`    sNMMMMN/  .NMMMMMd`   ::                                   ");
System.Console.WriteLine("                                    ./.`  :mMMMMm.  `hMMMMN+  `-+`                                   ");
System.Console.WriteLine("                                     `+`   .+ss+. .- `/syo:   .o`                                    ");
System.Console.WriteLine("                                      ./:--`     -++:    ``--:/.                                     ");
System.Console.WriteLine("                                        ``.o- `     `    :o.```                                      ");
System.Console.WriteLine("                                          .s--/--.-/---/-:s.                                         ");
System.Console.WriteLine("                                          -+``:```.:```:``:/                                         ");
System.Console.WriteLine("                                    .----:.-::::/----:-::/:.:----.                                   ");
System.Console.WriteLine("                                   `o./-`.o.-::/o-``-o:::-.o.`-/.o`                                  ");
System.Console.WriteLine("                                    s  `.:h:.:....  .`..:.:h:-`  s                                   ");
System.Console.WriteLine("                                   `s`/:.:s-`+::/s``s/::+`-s:.:/`s`                                  ");
System.Console.WriteLine("                                   o..+ -/.++::::/``/::::++./: +..o`                                 ");
System.Console.WriteLine("                                 `/: :: /:`-/:://+..o//::/-`// -: :/`                                ");
System.Console.WriteLine("                                /:.  /:/:-+/----:+..+:---:/+-:/:/  .:/                               ");
System.Console.WriteLine("                                s.:..-oo``/////+++--+++/////``o+-`.:.s                               ");
System.Console.WriteLine("                                s-s-/o`:+::/:::::////-::::/::+:`o/.s-o                               ");
System.Console.WriteLine("                                +:o-/` -/`.o:--://../::--:o.`/- `/-o-+                               ");
System.Console.WriteLine("                                o/-o`   -::-:::/o-::-o/::::::-   `o-/o                               ");
System.Console.WriteLine("                                ss-+      -/+/:-s-  .o-:/+/-      +-os                               ");
System.Console.WriteLine("                               /+/:o     /:.-:::/-``-::-.--:/     o:/+/                              ");
System.Console.WriteLine("                              /+..-o-`  `s``+:-:/-``-/--:+``s`   -s-.-+/                             ");
System.Console.WriteLine("                             -+s+:s//+   -/.-::-:/::/:://-./-   +//s:+s+-                            ");
System.Console.WriteLine("                             +/++:o:o+-   .s..:+  ``  +:..s.   -+o:o-+o/+                            ");
System.Console.WriteLine("                             :/y:o::--`   `s``-s-:::/-s-``s`   `-.::o:y+:                            ");
System.Console.WriteLine("                             `+y+s:s`    `/:`o-`.`  `.`-o.:/     `s:s+y+`                            ");
System.Console.WriteLine("                              `---:/.    /:`o.          .o`:/`   ./:---`                             ");
System.Console.WriteLine("                                     .::/- /-            :/ -/::.                                    ");
System.Console.WriteLine("                                     o-`  `s`            `s`  `-o                                    ");
System.Console.WriteLine("                                    :/-/+--s.            .s--+:-/:                                   ");
System.Console.WriteLine("                                    :+./o:-.o`          `o.-:o/.+:                                   ");
System.Console.WriteLine("                                    :/-..s/`s`          `o`/s.`-/:                                   ");
System.Console.WriteLine("                                     :o`+.o`o            o`o.+`o:                                    ");
System.Console.WriteLine("                                      /:+.o`o`           o`+.+:/                                     ");
System.Console.WriteLine("                                       o.oo`s            s`oo.o                                      ");
System.Console.WriteLine("                                       o`:h`o            o.h/`o                                      ");
System.Console.WriteLine("                                    ``.y/:+/+            +/+:/y..`                                   ");
System.Console.WriteLine("                              `:+::/y:-.s.``o`          `o``.s.-:y+::+:`                             ");
System.Console.WriteLine("                              .sy+++/++::+::-            -::+::++/+++yo.                             ");
System.Console.WriteLine("                               -/yo-/:``                      `.:/-oy/:                              ");
System.Console.WriteLine("                                .::-                              -::.                               ");
SparringMatch(me,jack); 
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();





System.Console.WriteLine("You notice there is only a single hallway leading up.");
System.Console.WriteLine("You take that path..");
me.MoveNorth();
System.Console.WriteLine("              .ss/.                                                                                 ");
System.Console.WriteLine("            `ohhhhhs/.                                                                              ");
System.Console.WriteLine("           :hddddhhhhho.                                                                            ");
System.Console.WriteLine("          +hdddddddhhy/.                                                                            ");
System.Console.WriteLine("        .yddhhhhhhhhsooo/.                                                                          ");
System.Console.WriteLine("       /ddddhhhhhhhsoossso/`                                                                        ");
System.Console.WriteLine("     .sdddddhhhyyysoooooooo+:`                                                                      ");
System.Console.WriteLine("   `odddddddhhyy+.`-+ooooooo++:`                                                                    ");
System.Console.WriteLine(" .oddddddddhhhy+`    `:+oooo++++:.                                                                  ");
System.Console.WriteLine("-hdddddhhhddhh+         .:+oooo+++/:.                                                               ");
System.Console.WriteLine(" ./yhddhhhhhhs`            .:+oooo+++/:.                                                            ");
System.Console.WriteLine("    ./oyhhhhy.                .:+oooooo+/:.                                                         ");
System.Console.WriteLine("       `.-/+/                    .:+ooooooo+:.`                                                     ");
System.Console.WriteLine("                                    `-/+oooooo+/-`                                                  ");
System.Console.WriteLine("                                       `.:+oooooo+/-.                                               ");
System.Console.WriteLine("                                           `-/oooooo++:.`                                           ");
System.Console.WriteLine("                                              `.:+oooooo+/-`                                        ");
System.Console.WriteLine("                                                  .:+ooooooo+:.`                                    ");
System.Console.WriteLine("                                                    `-/+oooooo+/-`                                  ");
System.Console.WriteLine("                                                        .:+ooossoo+:.                               ");
System.Console.WriteLine("                                                          `-/oossssso/.`                            ");
System.Console.WriteLine("                                                             `.:+ossssso/-`                         ");
System.Console.WriteLine("                                                                 `:+ossssoo/-`                      ");
System.Console.WriteLine("                                                                    `-/oosssoo/-`                   ");
System.Console.WriteLine("                                                                        `./osssoo+/.`               ");
System.Console.WriteLine("                                                                            `./ossooo+:.            ");
System.Console.WriteLine("                                                                               `-/osssoo+:`         ");
System.Console.WriteLine("                                                                                  `-+ssssoo+-`      ");
System.Console.WriteLine("                                                                                     .:ossssoo/.    ");
System.Console.WriteLine("                                                                                       `:ssssssso:` ");
System.Console.WriteLine("                                                                                         .osss+ysss:");
System.Console.WriteLine("                                                                                         `+yyyysso` ");
System.Console.WriteLine("                                                                                            -+oo:.  ");
 System.Console.WriteLine("In this room you discovered a Axe! Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No]");
 int pickup10 = Convert.ToInt32(Console.ReadLine());
 if(pickup10 == 1)
    {
       inventory.Add(P3);
       System.Console.WriteLine("You added an axe to your inventory");
    }
  if(pickup10 == 2)
    {
      System.Console.WriteLine("You left the axe to itself and continue your journey");

      }
 System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem11 = System.Console.ReadLine().ToLower();
    
    if(UseItem11 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
     if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }
       }     
 System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();



      System.Console.WriteLine("You notice 2 hallways, 1 going up, and another going to the right.");
      System.Console.WriteLine("[Enter up to go up] or [Enter right to go right]");
    string HallWayChoice6 = System.Console.ReadLine().ToLower();
    if(HallWayChoice6 == "up")
    {
      System.Console.WriteLine("You go up.");
      me.MoveNorth();
      System.Console.WriteLine("You notice there is only a single hallway leading to the right.");
      System.Console.WriteLine("You take that path..");
      me.MoveEast();
System.Console.WriteLine("                                             ..--://+++.                                            ");
System.Console.WriteLine("                                             .-:/++osyy`                                            ");
System.Console.WriteLine("                                             ..-/+ossyo                                             ");
System.Console.WriteLine("                                           ``.-:+osyyyo```                                          ");
System.Console.WriteLine("                                          .``..+syhdddy:..                                          ");
System.Console.WriteLine("                                          .`...+osyhhhs:.-                                          ");
System.Console.WriteLine("                                          ....-+ooyyyy+/.-                                          ");
System.Console.WriteLine("                                           ..-/ssyyhhy/:.`                                          ");
System.Console.WriteLine("                                           `..-::/:/ooooo/                                          ");
System.Console.WriteLine("                                         `-:-::+o:+shyss+                                           ");
System.Console.WriteLine("                                        `:///////ooosy+/-                                           ");
System.Console.WriteLine("                                          `-+oo/o+:+hhyys++                                         ");
System.Console.WriteLine("                                         ``.-::://:oo.-+o:                                          ");
System.Console.WriteLine("                                           ``.---:o:`:+o`                                           ");
System.Console.WriteLine("                                               ` -++`+++                                            ");
System.Console.WriteLine("                                                `` .+o`oo/                                          ");
System.Console.WriteLine("                                                ````/o`oo/                                          ");
System.Console.WriteLine("                                                ````:o-+o+                                          ");
System.Console.WriteLine("                                                ````:o:/oo                                          ");
System.Console.WriteLine("                                                ````.-`-+o`                                         ");
System.Console.WriteLine("                                           `    ````````:o-                                         ");
System.Console.WriteLine("                                           `   `````````-++                                         ");
System.Console.WriteLine("                                          .`   ``````..../-                                         ");
System.Console.WriteLine("                                         ``.`....````......`                                        ");
System.Console.WriteLine("                                       `.....`````````..``..``                                      ");
System.Console.WriteLine("                                     ``....``.```.....``````..``                                    ");
System.Console.WriteLine("                                  ``..--::::://::::::::::---.....`                                  ");
System.Console.WriteLine("                                 :++///////////::::::///////:://++/`                                ");
System.Console.WriteLine("                                :syo/:/ooooooo+++/////++ooooosssyys+`                               ");
System.Console.WriteLine("                               -oy+-.-:+++ssyysoo+++++ossyysssyyysso:                               ");
System.Console.WriteLine("                               +oo-.-:/:-:/oyysoooooooosssyysssyyyys+`                              ");
System.Console.WriteLine("                              `+s/..-/:---/syyyyyyyyyyyyyyyyyssssysso-                              ");
System.Console.WriteLine("                              .+s+::/+:--:+hhhhhhhhhhhhhhhhyyyyssssso-                              ");
System.Console.WriteLine("                              .+oo++oo+//+yhddddddddhdddddddyysssssso-                              ");
System.Console.WriteLine("                              .+ooosssyyyyhdmmdddmddmmdmdmdddhyssssoo-                              ");
System.Console.WriteLine("                              `+osssshdddddmmmmmdmmmmmmmmddmdddhsssso-                              ");
System.Console.WriteLine("                              `/oosyhmmmmmmmmmmmmmmmmmmmmmmmmmmdyysso.                              ");
System.Console.WriteLine("                               -+ssydddmmmmmmmmmmmmmmmmmmmmmmmmdhyys+`                              ");
System.Console.WriteLine("                               `/osyddddddmmmmmmmmmmmmmmmmmmmmdddhyo-                               ");
System.Console.WriteLine("                               `./osyddddmmmmmmmmmmmmmmmmmmmmmddhys:``                              ");
System.Console.WriteLine("                               ``./+oyhdddmmmmmmmmmmmmmmmmmmddhhys/-.``                             ");
System.Console.WriteLine("                               ``.-:/osyyhhhddddddddddddddddhdhys+:-.``                             ");
System.Console.WriteLine("                                ``..--:/+osyyhhhdddddddddhhyso+/:--.``                              ");
System.Console.WriteLine("                                  ````.....----:::::::::::----....```                               ");
System.Console.WriteLine("                                     `````````````````````````````                                  ");
 System.Console.WriteLine("In this room you discovered a armor potion! Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No");
 int pickup11 = Convert.ToInt32(Console.ReadLine());
 if(pickup11 == 1)
    {
       inventory.Add(P2);
       System.Console.WriteLine("You added a armor potion to your inventory");
    }
  if(pickup11 == 2)
  {
     System.Console.WriteLine("You left the potion to itself and continue your journey");

     }
System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem12 = System.Console.ReadLine().ToLower();
    
    if(UseItem12 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
         if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }

       }     
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();


      System.Console.WriteLine("You notice there is only a single hallway leading up.");
      System.Console.WriteLine("You take that path..");
      me.MoveNorth();
    }

    if(HallWayChoice6 == "right")
    {
      System.Console.WriteLine("You go right.");
      me.MoveEast();
System.Console.WriteLine("In this room you encounter casper, the unfriendly ghost. you have no choice but to fight for your life!");
System.Console.WriteLine("                                               ```````                                               ");
System.Console.WriteLine("                                           `````       ````                                          ");
System.Console.WriteLine("                                         `.`               ``                                        ");
System.Console.WriteLine("                                       `.`                  `.                                       ");
System.Console.WriteLine("                                      `.                      .                                      ");
System.Console.WriteLine("                                     `.       ````    ```     `.                                     ");
System.Console.WriteLine("                                     .       ``::.` `.::``     .`                                    ");
System.Console.WriteLine("                                    ``        :mmy`  smm+       .                                    ");
System.Console.WriteLine("                                    .        `hmmm- `mmmd.      ``                                   ");
System.Console.WriteLine("                                   `.       .hmmmm- .mmmmd-      .                                   ");
System.Console.WriteLine("                                   .       -dmmmmm. `mmmmmd-     .                                   ");
System.Console.WriteLine("                                   .   .   ymmmmmy   smmmmmd     ``                                  ");
System.Console.WriteLine("                                   .  `.   sddddh-   .hddddy      .                                  ");
System.Console.WriteLine("                       ``` `      .   ``  `./oo/-`   `./oo/.`     .                                  ");
System.Console.WriteLine("                     .`````````   .    .   `...-:------....`      .         `                        ");
System.Console.WriteLine("                    .`        ````.``  -`      smmmmmmm/          .       `.````.                    ");
System.Console.WriteLine("                    .                 `.``     ymmmmmmm+      ``````    ```     .`                   ");
System.Console.WriteLine("                    .```````````````````.``````-mmmmmmd````````````.`````````````.                   ");
System.Console.WriteLine("                    -``.````````````````-```````ymmmmm+```````.`` ````````````.``-                   ");
System.Console.WriteLine("                    -::.````````````````.```````:mmmmm````````-``````````````.:.`:                   ");
System.Console.WriteLine("                     -:.```````````````.````````.mmmmd````````-``````````````-:::/                   ");
System.Console.WriteLine("                      :.````````.````````````````ymmm+````````-`````````````.:/:::                   ");
System.Console.WriteLine("                      ::```````..````````````````./+:`````````-````````````.-:/:-`                   ");
System.Console.WriteLine("                      -::.````.:-````.`````````-``````..``````.`````.``-::::::/                      ");
System.Console.WriteLine("                      `/::---:::-````-``````````:-...-:``.````.`````-``:::::::-                      ");
System.Console.WriteLine("                        `.-:::::-````-```````````-:::-```.`````````.::::::::::`                      ");
System.Console.WriteLine("                           `-::/.````-```````````````````-`````````-/:::/::::-                       ");
System.Console.WriteLine("                             `/:````.-`````````.`````````-`````````::::.                             ");
System.Console.WriteLine("                              :-````-``````````.`````````-````````./::-                              ");
System.Console.WriteLine("                              -`````-`````````.-`````````-.```````-+:-                               ");
System.Console.WriteLine("            `                `-`````-``.```````-`````````.-``````.::`                                ");
System.Console.WriteLine("                             ..```.-...:..`````-`````````.:`````.-:-                                 ");
System.Console.WriteLine("                             -.....-.`.:.......-..........-......::-                                 ");
System.Console.WriteLine("                            ........-..:-......-.........-.......::-                                 ");
System.Console.WriteLine("                            -.......-..-:......-.........-.....-:::-                                 ");
System.Console.WriteLine("                            -::::..-:.../................-....-::::-                                 ");
System.Console.WriteLine("                             -::::-::-..::....................-::::-                                 ");
System.Console.WriteLine("                              ./::::::..:/-................-..-::::-                                 ");
System.Console.WriteLine("                               -:::::::::/:-..........-....:--:::::.                                 ");
System.Console.WriteLine("                                -:::::::::/:-.........:-..-::::-.``                                  ");
System.Console.WriteLine("                                 ::::..::::::-.......-:-.-:/:::                                      ");
System.Console.WriteLine("                                 `.`   `:::::-.......-:--::/:.`                                      ");
System.Console.WriteLine("                                        `:::::-------:::-:/.                                         ");
System.Console.WriteLine("                                         `::::-------::/:::                                          ");
System.Console.WriteLine("                                           ::::-----:::/::.                                          ");
System.Console.WriteLine("                                            -:::----:://:/                                           ");
System.Console.WriteLine("                                             .::::::::/::.                                           ");
System.Console.WriteLine("                                              `::::::::.`                                            ");
System.Console.WriteLine("                                                .::::/`                                              ");
System.Console.WriteLine("                                                  :::-                                               ");
System.Console.WriteLine("                                                   ..                                                ");
SparringMatch(me,casper); 
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();





      System.Console.WriteLine("You notice there are 2 hallways, one going right, and the other up.");
      System.Console.WriteLine("[Enter right to go right] or [Enter up to go up]");
      System.Console.WriteLine("what path do you choose?..");      
      
      string HallWayChoice7 = System.Console.ReadLine().ToLower();
        if(HallWayChoice7 == "up")
        {
          System.Console.WriteLine("You go up.");
          me.MoveNorth();
System.Console.WriteLine("                                             ..--://+++.                                            ");
System.Console.WriteLine("                                             .-:/++osyy`                                            ");
System.Console.WriteLine("                                             ..-/+ossyo                                             ");
System.Console.WriteLine("                                           ``.-:+osyyyo```                                          ");
System.Console.WriteLine("                                          .``..+syhdddy:..                                          ");
System.Console.WriteLine("                                          .`...+osyhhhs:.-                                          ");
System.Console.WriteLine("                                          ....-+ooyyyy+/.-                                          ");
System.Console.WriteLine("                                           ..-/ssyyhhy/:.`                                          ");
System.Console.WriteLine("                                           `..-::/:/ooooo/                                          ");
System.Console.WriteLine("                                         `-:-::+o:+shyss+                                           ");
System.Console.WriteLine("                                        `:///////ooosy+/-                                           ");
System.Console.WriteLine("                                          `-+oo/o+:+hhyys++                                         ");
System.Console.WriteLine("                                         ``.-::://:oo.-+o:                                          ");
System.Console.WriteLine("                                           ``.---:o:`:+o`                                           ");
System.Console.WriteLine("                                               ` -++`+++                                            ");
System.Console.WriteLine("                                                `` .+o`oo/                                          ");
System.Console.WriteLine("                                                ````/o`oo/                                          ");
System.Console.WriteLine("                                                ````:o-+o+                                          ");
System.Console.WriteLine("                                                ````:o:/oo                                          ");
System.Console.WriteLine("                                                ````.-`-+o`                                         ");
System.Console.WriteLine("                                           `    ````````:o-                                         ");
System.Console.WriteLine("                                           `   `````````-++                                         ");
System.Console.WriteLine("                                          .`   ``````..../-                                         ");
System.Console.WriteLine("                                         ``.`....````......`                                        ");
System.Console.WriteLine("                                       `.....`````````..``..``                                      ");
System.Console.WriteLine("                                     ``....``.```.....``````..``                                    ");
System.Console.WriteLine("                                  ``..--::::://::::::::::---.....`                                  ");
System.Console.WriteLine("                                 :++///////////::::::///////:://++/`                                ");
System.Console.WriteLine("                                :syo/:/ooooooo+++/////++ooooosssyys+`                               ");
System.Console.WriteLine("                               -oy+-.-:+++ssyysoo+++++ossyysssyyysso:                               ");
System.Console.WriteLine("                               +oo-.-:/:-:/oyysoooooooosssyysssyyyys+`                              ");
System.Console.WriteLine("                              `+s/..-/:---/syyyyyyyyyyyyyyyyyssssysso-                              ");
System.Console.WriteLine("                              .+s+::/+:--:+hhhhhhhhhhhhhhhhyyyyssssso-                              ");
System.Console.WriteLine("                              .+oo++oo+//+yhddddddddhdddddddyysssssso-                              ");
System.Console.WriteLine("                              .+ooosssyyyyhdmmdddmddmmdmdmdddhyssssoo-                              ");
System.Console.WriteLine("                              `+osssshdddddmmmmmdmmmmmmmmddmdddhsssso-                              ");
System.Console.WriteLine("                              `/oosyhmmmmmmmmmmmmmmmmmmmmmmmmmmdyysso.                              ");
System.Console.WriteLine("                               -+ssydddmmmmmmmmmmmmmmmmmmmmmmmmdhyys+`                              ");
System.Console.WriteLine("                               `/osyddddddmmmmmmmmmmmmmmmmmmmmdddhyo-                               ");
System.Console.WriteLine("                               `./osyddddmmmmmmmmmmmmmmmmmmmmmddhys:``                              ");
System.Console.WriteLine("                               ``./+oyhdddmmmmmmmmmmmmmmmmmmddhhys/-.``                             ");
System.Console.WriteLine("                               ``.-:/osyyhhhddddddddddddddddhdhys+:-.``                             ");
System.Console.WriteLine("                                ``..--:/+osyyhhhdddddddddhhyso+/:--.``                              ");
System.Console.WriteLine("                                  ````.....----:::::::::::----....```                               ");
System.Console.WriteLine("                                     `````````````````````````````                                  ");
 System.Console.WriteLine("In this room you discovered a armor potion! Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No]");
 int pickup12 = Convert.ToInt32(Console.ReadLine());
 if(pickup12 == 1)
    {
       inventory.Add(P2);
       System.Console.WriteLine("You added a armor potion to your inventory");
    }
  if(pickup12 == 2)
  {
     System.Console.WriteLine("You left the potion to itself and continue your journey");

     }
System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem13 = System.Console.ReadLine().ToLower();
    
    if(UseItem13 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
         if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }

       }     
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();


          System.Console.WriteLine("You notice there is only a single hallway leading up.");
          System.Console.WriteLine("You take that path..");
          me.MoveNorth();
        }
        if(HallWayChoice7 == "right")
        {
          System.Console.WriteLine("You go right.");
          me.MoveEast();
System.Console.WriteLine("                                             ..--://+++.                                            ");
System.Console.WriteLine("                                             .-:/++osyy`                                            ");
System.Console.WriteLine("                                             ..-/+ossyo                                             ");
System.Console.WriteLine("                                           ``.-:+osyyyo```                                          ");
System.Console.WriteLine("                                          .``..+syhdddy:..                                          ");
System.Console.WriteLine("                                          .`...+osyhhhs:.-                                          ");
System.Console.WriteLine("                                          ....-+ooyyyy+/.-                                          ");
System.Console.WriteLine("                                           ..-/ssyyhhy/:.`                                          ");
System.Console.WriteLine("                                           `..-::/:/ooooo/                                          ");
System.Console.WriteLine("                                         `-:-::+o:+shyss+                                           ");
System.Console.WriteLine("                                        `:///////ooosy+/-                                           ");
System.Console.WriteLine("                                          `-+oo/o+:+hhyys++                                         ");
System.Console.WriteLine("                                         ``.-::://:oo.-+o:                                          ");
System.Console.WriteLine("                                           ``.---:o:`:+o`                                           ");
System.Console.WriteLine("                                               ` -++`+++                                            ");
System.Console.WriteLine("                                                `` .+o`oo/                                          ");
System.Console.WriteLine("                                                ````/o`oo/                                          ");
System.Console.WriteLine("                                                ````:o-+o+                                          ");
System.Console.WriteLine("                                                ````:o:/oo                                          ");
System.Console.WriteLine("                                                ````.-`-+o`                                         ");
System.Console.WriteLine("                                           `    ````````:o-                                         ");
System.Console.WriteLine("                                           `   `````````-++                                         ");
System.Console.WriteLine("                                          .`   ``````..../-                                         ");
System.Console.WriteLine("                                         ``.`....````......`                                        ");
System.Console.WriteLine("                                       `.....`````````..``..``                                      ");
System.Console.WriteLine("                                     ``....``.```.....``````..``                                    ");
System.Console.WriteLine("                                  ``..--::::://::::::::::---.....`                                  ");
System.Console.WriteLine("                                 :++///////////::::::///////:://++/`                                ");
System.Console.WriteLine("                                :syo/:/ooooooo+++/////++ooooosssyys+`                               ");
System.Console.WriteLine("                               -oy+-.-:+++ssyysoo+++++ossyysssyyysso:                               ");
System.Console.WriteLine("                               +oo-.-:/:-:/oyysoooooooosssyysssyyyys+`                              ");
System.Console.WriteLine("                              `+s/..-/:---/syyyyyyyyyyyyyyyyyssssysso-                              ");
System.Console.WriteLine("                              .+s+::/+:--:+hhhhhhhhhhhhhhhhyyyyssssso-                              ");
System.Console.WriteLine("                              .+oo++oo+//+yhddddddddhdddddddyysssssso-                              ");
System.Console.WriteLine("                              .+ooosssyyyyhdmmdddmddmmdmdmdddhyssssoo-                              ");
System.Console.WriteLine("                              `+osssshdddddmmmmmdmmmmmmmmddmdddhsssso-                              ");
System.Console.WriteLine("                              `/oosyhmmmmmmmmmmmmmmmmmmmmmmmmmmdyysso.                              ");
System.Console.WriteLine("                               -+ssydddmmmmmmmmmmmmmmmmmmmmmmmmdhyys+`                              ");
System.Console.WriteLine("                               `/osyddddddmmmmmmmmmmmmmmmmmmmmdddhyo-                               ");
System.Console.WriteLine("                               `./osyddddmmmmmmmmmmmmmmmmmmmmmddhys:``                              ");
System.Console.WriteLine("                               ``./+oyhdddmmmmmmmmmmmmmmmmmmddhhys/-.``                             ");
System.Console.WriteLine("                               ``.-:/osyyhhhddddddddddddddddhdhys+:-.``                             ");
System.Console.WriteLine("                                ``..--:/+osyyhhhdddddddddhhyso+/:--.``                              ");
System.Console.WriteLine("                                  ````.....----:::::::::::----....```                               ");
System.Console.WriteLine("                                     `````````````````````````````                                  ");

 System.Console.WriteLine("In this room you discovered a potion of healing that heals for 25hp. Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No");
 int pickup13 = Convert.ToInt32(Console.ReadLine());
 if(pickup13 == 1)
    {
       inventory.Add(P1);
       System.Console.WriteLine("You added a healing potion to your inventory");
    }
  if(pickup13 ==2)
    {
      System.Console.WriteLine("You left the potion to itself and continue your journey");

      }
 System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem14 = System.Console.ReadLine().ToLower();
    
    if(UseItem14 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
         if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }

       }     
 System.Console.WriteLine("Press any key to continue..."); 
 Console.ReadKey(); 
 System.Console.Clear();

          System.Console.WriteLine("You notice there is only a single hallway leading up.");
          System.Console.WriteLine("You take that path..");
          me.MoveNorth();
System.Console.WriteLine("In this room you encounter a vampire, you have no choice but to fight for your life!");          
System.Console.WriteLine("                                                -/oyhdddhys/.                                       ");
System.Console.WriteLine("                                             `+dmNmmmNNNNNNNm+                                      ");
System.Console.WriteLine("                                            /dmdysooyyyyhmNNNm+                                     ");
System.Console.WriteLine("                                           :ho:--:+so/:--:+shmm+                                    ");
System.Console.WriteLine("                                          `y+:...--:------:/oymd                                    ");
System.Console.WriteLine("                                        .`-o:oyo/-.--.:/+ss//hmd                                    ");
System.Console.WriteLine("                                       `:::::/+oho/:/osyy+///mNo`..                                 ");
System.Console.WriteLine("                                        ://-:-:::--./-:///::/sh:::.                                 ");
System.Console.WriteLine("                                        -/::------../:-.---:/+o//-                                  ");
System.Console.WriteLine("                                     /`  .-///:---::+:---////++:-` :.                               ");
System.Console.WriteLine("                                     dd+. `://s.:::::::-yo////.`  `dy                               ");
System.Console.WriteLine("                              ```` ` /NNmy+/::/+hhysyy/o+:://- `-/yNy                               ");
System.Console.WriteLine("                           ..-:+/.``` omNNNm+::/yyyysso/::/+ssydmmmm-                               ");
System.Console.WriteLine("                          . .:+s+-../  +mNNNmo::::::/::::/odNNNNNmd:     ``                         ");
System.Console.WriteLine("                         `.`.-//:://:   -ymNNms:::::::::/+mmNNNmho.     `::```                      ");
System.Console.WriteLine("                         .::/ossyyho/     :dmmh`-::::--/osNmmmm+.`..   .-:-:::`                     ");
System.Console.WriteLine("                          .:/oosssy+`    .ymN++` ````.oo:hNNdmdy. .--.---::/:-                      ");
System.Console.WriteLine("                           .::::+++`     odmd``.:`.--.:-:mddddNdd/ -::::::/:/-                      ");
System.Console.WriteLine("                            .::-++/`.    hmm:  ./.:+-..-oNNddNNNmmo`::::::/::.                      ");
System.Console.WriteLine("                             .:.++./my/.-dm/  ..-..-``..hNdmNmNNmmmy`-///:-`                        ");
System.Console.WriteLine("                               .+-/dNNNNmdo  `.-.--.....mdmNmymmmdmNs:-:`                           ");
System.Console.WriteLine("                            `.://:odmNNNNd`    `. ```...smNNhyymmmNNNmh:                            ");
System.Console.WriteLine("                            ......` -+ymm+`   `.`  ``...:dNmyyyymNNNNNNm-                           ");
System.Console.WriteLine("                                       sd/`   :s/` ```..-omNhyyyyhdhmNNNm/                          ");
System.Console.WriteLine("                                       yhNy-+dNNNm+``./sdNdNmyyyyyyyhmNNNN/                         ");
System.Console.WriteLine("                                       odNNmNNNNNNNddmmNNNmmNhyyyyyyyhNNNNN/                        ");
System.Console.WriteLine("                                       .mNNNNNNNNNNNNNNNNNNdNdyyyyyyyhdNNNNm/                       ");
System.Console.WriteLine("                                        hNNNNNNNNNNNNNNNNNNNmmyyyyyyyhymNNNNm-                      ");
System.Console.WriteLine("                                        /NNNNNNNNNNNNNNNNNNNmmyyyyyyyhyhNNNNNd`                     ");
System.Console.WriteLine("                                       `-mNNmmmmmddddmNNNNNNNmyyyyyyyhyymNNNNNs                     ");
System.Console.WriteLine("                    `-.`          .:oyddmNNNNNNNNNddmmNNNNNNNNhyyyyyyyyyhNNNNNm.                    ");
System.Console.WriteLine("                 ./ydmmd+.      -shdmmmmNmNNNNNNNNdhmNNNNNNNNNmyyyyyyyyyhNNNNNN/                    ");
System.Console.WriteLine("               `+dmmmNNNNds:` `ohdddddhhhhdNNNNNNNhydNNNNNNNNNNmyyyyyyyyyNNNNNNo                    ");
System.Console.WriteLine("              :hhhdmmNNNNNNmdhydddhyyyyyyyhNNNNNNmhyhNNNNNNNNdmmmyyyyyyyyNNNNNNo                    ");
System.Console.WriteLine("            `//.```.+dNNNNNNNdhhyyyyyyyyyhhNNNNNNdhyymNmNNNNNhyyhhyyo/./hNNNNNN-                    ");
System.Console.WriteLine("            .`       .yNNNNNmhhyyyyyhhhhhhhmNNNNmmdy/yNmmNNNNmyyys+-`   yNNNNNy                     ");
System.Console.WriteLine("                      `yNNNNdhyso///ohhhhhhhNNNNmNmh/ymNdhmNNNy/-`     .mNNNms`                     ");
System.Console.WriteLine("                       `+hmmy+-`    -hyys+::NNNNNNmdo:mNmdNNNNy       `hNNmh/                       ");
System.Console.WriteLine("                         `.-`      `--.`    NNNNNmhmh yNdmNNNNm      `ymds:`                        ");
System.Console.WriteLine("                                            mNNNNdmNm`/mhmNNNNN-     /+-`                           ");
System.Console.WriteLine("                                           dNNNNNNNd.`mmdmNNNNs                                     ");
System.Console.WriteLine("                                     ``````.smNNmmNNo``ohNNNNNm+                                    ");
System.Console.WriteLine("                           ````....---::/oymNmdhddmm+::::ddmNNm/-....````                           ");
System.Console.WriteLine("                        ``...---::/++oshmmNmdysooo+///////hmmmmms:---...```                         ");
System.Console.WriteLine("                         ```...-shhhhhhddys+::::::::::::::smhyyddhs..```                            ");
System.Console.WriteLine("                                ```....```...........`````:ddhyo++d/                                ");
System.Console.WriteLine("                   `..`````                                `-/osyys-                                ");
SparringMatch(me,Frank); 
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();




System.Console.WriteLine("You notice there is only a single hallway leading left.");
System.Console.WriteLine("You take that path..");
me.MoveWest();
System.Console.WriteLine("                                             ..--://+++.                                            ");
System.Console.WriteLine("                                             .-:/++osyy`                                            ");
System.Console.WriteLine("                                             ..-/+ossyo                                             ");
System.Console.WriteLine("                                           ``.-:+osyyyo```                                          ");
System.Console.WriteLine("                                          .``..+syhdddy:..                                          ");
System.Console.WriteLine("                                          .`...+osyhhhs:.-                                          ");
System.Console.WriteLine("                                          ....-+ooyyyy+/.-                                          ");
System.Console.WriteLine("                                           ..-/ssyyhhy/:.`                                          ");
System.Console.WriteLine("                                           `..-::/:/ooooo/                                          ");
System.Console.WriteLine("                                         `-:-::+o:+shyss+                                           ");
System.Console.WriteLine("                                        `:///////ooosy+/-                                           ");
System.Console.WriteLine("                                          `-+oo/o+:+hhyys++                                         ");
System.Console.WriteLine("                                         ``.-::://:oo.-+o:                                          ");
System.Console.WriteLine("                                           ``.---:o:`:+o`                                           ");
System.Console.WriteLine("                                               ` -++`+++                                            ");
System.Console.WriteLine("                                                `` .+o`oo/                                          ");
System.Console.WriteLine("                                                ````/o`oo/                                          ");
System.Console.WriteLine("                                                ````:o-+o+                                          ");
System.Console.WriteLine("                                                ````:o:/oo                                          ");
System.Console.WriteLine("                                                ````.-`-+o`                                         ");
System.Console.WriteLine("                                           `    ````````:o-                                         ");
System.Console.WriteLine("                                           `   `````````-++                                         ");
System.Console.WriteLine("                                          .`   ``````..../-                                         ");
System.Console.WriteLine("                                         ``.`....````......`                                        ");
System.Console.WriteLine("                                       `.....`````````..``..``                                      ");
System.Console.WriteLine("                                     ``....``.```.....``````..``                                    ");
System.Console.WriteLine("                                  ``..--::::://::::::::::---.....`                                  ");
System.Console.WriteLine("                                 :++///////////::::::///////:://++/`                                ");
System.Console.WriteLine("                                :syo/:/ooooooo+++/////++ooooosssyys+`                               ");
System.Console.WriteLine("                               -oy+-.-:+++ssyysoo+++++ossyysssyyysso:                               ");
System.Console.WriteLine("                               +oo-.-:/:-:/oyysoooooooosssyysssyyyys+`                              ");
System.Console.WriteLine("                              `+s/..-/:---/syyyyyyyyyyyyyyyyyssssysso-                              ");
System.Console.WriteLine("                              .+s+::/+:--:+hhhhhhhhhhhhhhhhyyyyssssso-                              ");
System.Console.WriteLine("                              .+oo++oo+//+yhddddddddhdddddddyysssssso-                              ");
System.Console.WriteLine("                              .+ooosssyyyyhdmmdddmddmmdmdmdddhyssssoo-                              ");
System.Console.WriteLine("                              `+osssshdddddmmmmmdmmmmmmmmddmdddhsssso-                              ");
System.Console.WriteLine("                              `/oosyhmmmmmmmmmmmmmmmmmmmmmmmmmmdyysso.                              ");
System.Console.WriteLine("                               -+ssydddmmmmmmmmmmmmmmmmmmmmmmmmdhyys+`                              ");
System.Console.WriteLine("                               `/osyddddddmmmmmmmmmmmmmmmmmmmmdddhyo-                               ");
System.Console.WriteLine("                               `./osyddddmmmmmmmmmmmmmmmmmmmmmddhys:``                              ");
System.Console.WriteLine("                               ``./+oyhdddmmmmmmmmmmmmmmmmmmddhhys/-.``                             ");
System.Console.WriteLine("                               ``.-:/osyyhhhddddddddddddddddhdhys+:-.``                             ");
System.Console.WriteLine("                                ``..--:/+osyyhhhdddddddddhhyso+/:--.``                              ");
System.Console.WriteLine("                                  ````.....----:::::::::::----....```                               ");
System.Console.WriteLine("                                     `````````````````````````````                                  ");
 System.Console.WriteLine("In this room you discovered a armor potion! Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No]");
 int pickup14 = Convert.ToInt32(Console.ReadLine());
 if(pickup14 == 1)
    {
       inventory.Add(P2);
       System.Console.WriteLine("You added a armor potion to your inventory");
    }
  if(pickup14 == 2)
  {
     System.Console.WriteLine("You left the potion to itself and continue your journey");

     }
System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem15 = System.Console.ReadLine().ToLower();
    
    if(UseItem15 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
     if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }
       }     
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();          
          System.Console.WriteLine("You notice there is only a single hallway leading up.");
          System.Console.WriteLine("You take that path..");
          me.MoveNorth(); 
        }
    }
  }


}


System.Console.WriteLine("////////////////////////////////////////////////////////////");
System.Console.WriteLine("////                    CONGRATS                        ////");
System.Console.WriteLine("////                 YOU'VE ESCAPED                     ////");
System.Console.WriteLine("////                    YOU WIN                         ////");
System.Console.WriteLine("////////////////////////////////////////////////////////////");
 System.Environment.Exit(0);





  }
  if (Elevator == 2){
   System.Console.WriteLine("You have chosen the right elevator, along with your journey...");
    PlayerCharacter me = new PlayerCharacter(PCname,Sp33d);
    me.ChangeRace(RacePicked);
    System.Console.Clear();
System.Console.WriteLine("______________________________________");
System.Console.WriteLine("|                                    |");
System.Console.WriteLine("| ...................................|");
System.Console.WriteLine("| ..............`     `..............|");
System.Console.WriteLine("| .............`        .............|");
System.Console.WriteLine("| .............`        .............|");
System.Console.WriteLine("| .............         `............|");
System.Console.WriteLine("| ..............       `.............|");
System.Console.WriteLine("| ...............     `..............|");
System.Console.WriteLine("| ...............     `..............|");
System.Console.WriteLine("| .............`       ``............|");
System.Console.WriteLine("| .........``              ``........|");
System.Console.WriteLine("| .......`                    .......|");
System.Console.WriteLine("|____________________________________|");
System.Console.WriteLine(me);
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();
System.Console.WriteLine("You go down in the elevator and find yourself in the basement of the building.. ");
System.Console.WriteLine("You exit the elevator and see a map in front of you.");
System.Console.WriteLine("You look at the map and it comes clear to you that you need to escape!");
    Potion P1 = new HealingPotion();
    P1.recipient = me;
    Potion P2 = new ArmorPotion();
    P2.recipient = me;
    Weapon P3 = new Axe();
    P3.recipient = me;
                                                                                                                                                      
                                                                                                                                                      
System.Console.WriteLine("                    //                                             ``        `                                            .:/++/:.         ");           
System.Console.WriteLine("                   /mm/                    `-`                  -syssys: `+ysosyo`                                     -syo/:--:/oys-      ");           
System.Console.WriteLine("                  :m--m:           ````````:Nss+-`             -m-`  `.hyd+`   `sh                                   .yy-`        `:hs`    ");           
System.Console.WriteLine("                 -m:  :m-         yhssssssssy``:oys/.          yy      `o/      `M-          `.:+osd-.........`     `m+             `sh`   ");           
System.Console.WriteLine("                .m/    /m.        ho             `-smh.        /m`              /m`     ./ossso+:..soooooooood+     sy               `m+   ");           
System.Console.WriteLine("               .d+      +d.       yhooooooooo `-+yy+-`          yy`            :m:      .+shys+/-``++++++++++mo     do                ys   ");           
System.Console.WriteLine("              `hs        sh`      `......../Msso:.`             `oh-         `od-           `.-/+oyd-.........`     +d`              `N:   ");           
System.Console.WriteLine("             `yy          yy`              `:.`                   -yy:`    .+h+`                  ``                `yy.            .ho    ");           
System.Console.WriteLine("             sm::::::::::::ms                                       .oys:+ss/`                                       `+ho.       `-oh/     ");           
System.Console.WriteLine("             /+////////////+/                                         `:mh-                                            `/osoo++ooso:`      ");           
System.Console.WriteLine("                  `os.                                               -yy/+yo.                                             `.-+s/.`         ");           
System.Console.WriteLine("                 /ho/h+`                                           :yd/   `ods-                                          `-oyo/sy/.        ");           
System.Console.WriteLine("               .ym/  .dd:                                         `oohh    Nso+                                        .+dd+`   -ymy/      ");           
System.Console.WriteLine("               -/hs  /m/:                                            +d    M-                                          .+/hy    :N///      ");           
System.Console.WriteLine("                 yy  /m                                              /h++++d-                                             sh....+m         ");           
System.Console.WriteLine("                 ohssyy                       ``                     .++++++.                      `ho-`                  :sooooss         ");           
System.Console.WriteLine("                  `````              .-------ohso/-`              .+ss+/::/+oso-           -soooooosm:+so/.          `-/++/.    .:/+/:.    ");           
System.Console.WriteLine("            :ooso+. `:ooso/.         hy++++++o/`./oys+-         `+h+.        `:ys.         /N........   ./sho`      :ho:--/sy:-sy+---+yo   ");           
System.Console.WriteLine("          oh-``./hshs-``.+d.        hs-------.  .-ohho         yy`            `+d.        /N:::::::-  .:sso:      .N:      -hd:`     `d/   ");          
System.Console.WriteLine("         `N:     `s:      do        /+++++++hh+sso:.          +d`               sh        `///////oMoss/-`        .N-       `.        d+   ");          
System.Console.WriteLine("           ys             -N:                -+:.              m/                .M.               `+:`             od.              `oh`  ");           
System.Console.WriteLine("           `hs`          :d/             `.:-                  m/                `M.           `-:oh.```````         +d/`           -yy`   ");           
System.Console.WriteLine("           `+y+.     `-sy-        `.-/ossoyd//////////-       +d`               sh        `-+sso/:ysssssssd          .sy+.      `:sy:      ");          
System.Console.WriteLine("             ./ys/-:+ys-        +yhy+:.`  `::::::::::hy        yy`            `+d.        +dds:.  .------/M            ./ss+-./oyo-        ");          
System.Console.WriteLine("                ./o+-`          -/osso/-.`.o+++++++++hs        `+h/.        `:ys`           .:+sssNo+++++++               .:oo/.           ");          
System.Console.WriteLine("                                    `-:+sshh.........-`          .+ss+/::/+sso-                 `-/                                        ");          
System.Console.WriteLine("                  `+/                     ..                        .-://:-.                                                 .+.           ");          
System.Console.WriteLine("                 .yyyy.                                                 -.                                                  :dsd.          ");          
System.Console.WriteLine("                /d/  +d/                                              `shd+`                                               +d- /d:         ");          
System.Console.WriteLine("                sNs.  .sNo                                            :ho``sy-                                             /Ny` .hm:       ");           
System.Console.WriteLine("                --N/  +m--                                           /md:  omd-                                            .-M. /N.`       ");           
System.Console.WriteLine("                  m/  +m                                              `ho  ho`                                              `M. /m         ");           
System.Console.WriteLine("                  ms::sd                                               hs..do                                               `No/sm         ");           
System.Console.WriteLine("              ````:////:                                               /soos-                                                -----         ");           
System.Console.WriteLine("          `:ossssssso/.                                                  -.                                          /++++++++++++++++++.  ");           
System.Console.WriteLine("        -sh+-`      ./yy:                                               +mm:                                         ds----------------N/  ");           
System.Console.WriteLine("       +d/             -hs`                                            +d.:m:                     `                  d+                N/  ");           
System.Console.WriteLine("      +m`                yh             ``-/oh/```````````            od.  -m/               ``:+ym:``````````       d+                N/  ");           
System.Console.WriteLine("      N:                 `N-       `./osss+:.sysssssssssyd`          sh`    .m+          `-+sys/-`yyssssssssyd       d+                N/  ");           
System.Console.WriteLine("      M-                  N:     `ymms:`                .M.        `yy`      .d+       -hms/.               -M       d+                N/  ");           
System.Console.WriteLine("      yy                 /m`       .:+ssso/.`oysssssssssym`       `hy         .ds       ./oyyo:`  ++++++++++sN       d+                N/  ");           
System.Console.WriteLine("      `hs`              /d-             `./oyd+                  `dy````````````dy           -/sysN+---------.       d+                N/  ");           
System.Console.WriteLine("        +d+`         `/hy`                                       /yssssssssssssssy-              `:`                 ds----------------N/  ");           
System.Console.WriteLine("         `/syso///+syy+`                                                                                             :++++++++++++++++++.  ");           
System.Console.WriteLine("             `.:::-`                                                                                                                       ");           
                                                                                                                                                      
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();                                                                                                                                                      

System.Console.WriteLine("You notice a hallway going straight, and another hallway going to your left.");
System.Console.WriteLine("Which way do you choose to go?");
System.Console.WriteLine("[Enter up to go up] or [Enter left to go left]");
string HallWayChoice = System.Console.ReadLine().ToLower();
if(HallWayChoice == "up")
{
  System.Console.WriteLine("You take the path up");
  me.MoveNorth();
                                                                                                      
System.Console.WriteLine("                                             ..--://+++.                                            ");
System.Console.WriteLine("                                             .-:/++osyy`                                            ");
System.Console.WriteLine("                                             ..-/+ossyo                                             ");
System.Console.WriteLine("                                           ``.-:+osyyyo```                                          ");
System.Console.WriteLine("                                          .``..+syhdddy:..                                          ");
System.Console.WriteLine("                                          .`...+osyhhhs:.-                                          ");
System.Console.WriteLine("                                          ....-+ooyyyy+/.-                                          ");
System.Console.WriteLine("                                           ..-/ssyyhhy/:.`                                          ");
System.Console.WriteLine("                                           `..-::/:/ooooo/                                          ");
System.Console.WriteLine("                                         `-:-::+o:+shyss+                                           ");
System.Console.WriteLine("                                        `:///////ooosy+/-                                           ");
System.Console.WriteLine("                                          `-+oo/o+:+hhyys++                                         ");
System.Console.WriteLine("                                         ``.-::://:oo.-+o:                                          ");
System.Console.WriteLine("                                           ``.---:o:`:+o`                                           ");
System.Console.WriteLine("                                               ` -++`+++                                            ");
System.Console.WriteLine("                                                `` .+o`oo/                                          ");
System.Console.WriteLine("                                                ````/o`oo/                                          ");
System.Console.WriteLine("                                                ````:o-+o+                                          ");
System.Console.WriteLine("                                                ````:o:/oo                                          ");
System.Console.WriteLine("                                                ````.-`-+o`                                         ");
System.Console.WriteLine("                                           `    ````````:o-                                         ");
System.Console.WriteLine("                                           `   `````````-++                                         ");
System.Console.WriteLine("                                          .`   ``````..../-                                         ");
System.Console.WriteLine("                                         ``.`....````......`                                        ");
System.Console.WriteLine("                                       `.....`````````..``..``                                      ");
System.Console.WriteLine("                                     ``....``.```.....``````..``                                    ");
System.Console.WriteLine("                                  ``..--::::://::::::::::---.....`                                  ");
System.Console.WriteLine("                                 :++///////////::::::///////:://++/`                                ");
System.Console.WriteLine("                                :syo/:/ooooooo+++/////++ooooosssyys+`                               ");
System.Console.WriteLine("                               -oy+-.-:+++ssyysoo+++++ossyysssyyysso:                               ");
System.Console.WriteLine("                               +oo-.-:/:-:/oyysoooooooosssyysssyyyys+`                              ");
System.Console.WriteLine("                              `+s/..-/:---/syyyyyyyyyyyyyyyyyssssysso-                              ");
System.Console.WriteLine("                              .+s+::/+:--:+hhhhhhhhhhhhhhhhyyyyssssso-                              ");
System.Console.WriteLine("                              .+oo++oo+//+yhddddddddhdddddddyysssssso-                              ");
System.Console.WriteLine("                              .+ooosssyyyyhdmmdddmddmmdmdmdddhyssssoo-                              ");
System.Console.WriteLine("                              `+osssshdddddmmmmmdmmmmmmmmddmdddhsssso-                              ");
System.Console.WriteLine("                              `/oosyhmmmmmmmmmmmmmmmmmmmmmmmmmmdyysso.                              ");
System.Console.WriteLine("                               -+ssydddmmmmmmmmmmmmmmmmmmmmmmmmdhyys+`                              ");
System.Console.WriteLine("                               `/osyddddddmmmmmmmmmmmmmmmmmmmmdddhyo-                               ");
System.Console.WriteLine("                               `./osyddddmmmmmmmmmmmmmmmmmmmmmddhys:``                              ");
System.Console.WriteLine("                               ``./+oyhdddmmmmmmmmmmmmmmmmmmddhhys/-.``                             ");
System.Console.WriteLine("                               ``.-:/osyyhhhddddddddddddddddhdhys+:-.``                             ");
System.Console.WriteLine("                                ``..--:/+osyyhhhdddddddddhhyso+/:--.``                              ");
System.Console.WriteLine("                                  ````.....----:::::::::::----....```                               ");
System.Console.WriteLine("                                     `````````````````````````````                                  ");

 System.Console.WriteLine("In this room you discovered a potion of healing! Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No]");
 int pickup = Convert.ToInt32(Console.ReadLine());
 if(pickup == 1)
    {
       inventory.Add(P1);
       System.Console.WriteLine("You added a healing potion to your inventory");
    }
  if(pickup == 2)
    {
      System.Console.WriteLine("You left the potion to itself and continue your journey");

      }
    System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem = System.Console.ReadLine().ToLower();
    
    if(UseItem == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
         if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }

       }
 System.Console.WriteLine("Press any key to continue..."); 
 Console.ReadKey(); 
 System.Console.Clear();
                                                                                                    
  System.Console.WriteLine("You notice a hallway going straight, and another hallway going to your left.");
  System.Console.WriteLine("Which way do you choose to go?");
  System.Console.WriteLine("[Enter up to go up] or [Enter left to go left]");
  string HallWayChoice2 = System.Console.ReadLine().ToLower();
  if(HallWayChoice2 == "up")
  {
    System.Console.WriteLine("You take the path up");
    me.MoveNorth();
    System.Console.WriteLine("In this room you encounter a leviathan, you have no choice but to fight for your life!");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````.---------.`````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````---:/+yssyy+.```````````````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````````````````:/:/dhhhhhso:`````````````````");
System.Console.WriteLine("````````````````....---.```````````````````````````````````````````````syydhddhhhhys.```````````````");
System.Console.WriteLine("```````````````://+syys+:.````````````````````````````````````````````:hhhhhhhdddddhy.``````````````");
System.Console.WriteLine("```````````````.```-ssysss/.`````````````````````````````````````````/hhddhhhhhddhhdhs.`````````````");
System.Console.WriteLine("````````````````````ossyssso-``````-``.`.:.````````````````````````-yhhddhhhhhhyhhhhhho.````````````");
System.Console.WriteLine("````````````````````-yyyyyooo+/:::+o.-oo+-`.://:.```````````````-:/hmhddhhhhyyyyyyhhhyho````````````");
System.Console.WriteLine("````````````````````-ossyyyyyyyyyhshyshh++oo/::///:.````````````-ysshddhhhyyhysyhyyyyyyy+```````````");
System.Console.WriteLine("```````````````````.../+ssssyyyshyhddhdhhhhysyh+-.--::-.```````-yhyyhhyyyyysyyyssyysyyyys/``````````");
System.Console.WriteLine("``````````````````````/:-sooyyysdhhhhdhhhhhhhyysosys+::-.`````-yyyhhyyyyssyyssyyssssoyyyso-`````````");
System.Console.WriteLine("`````````````````````:o+.osy/yyhysydddhhyyhyyyyyyyysooso+/-`./hyyyhyssysssosssosysosssyyyso-````````");
System.Console.WriteLine("`````````````````````oh+shhdhhhyyhhhyhhyyyyyssshyyysyhyy/--/yhhhhhhso+oossooosoossoosssyyyos````````");
System.Console.WriteLine("```````````````````-+hdhhddhhddddhyyyyyyyyssyyyysshhhdddhhhhhdhhhhhyo++ooooo+sso+osooooosyys/```````");
System.Console.WriteLine("`````````````````//yhhhhhhdyddhhhhyyhhhyyysyhyssooyyyhhhddddddhhysyys+/++sso+/oo++ooo+oooyysy-``````");
System.Console.WriteLine("``````````````:+sddhdhhshhhhhdddy++oyhhhhyyyhhysssyhyhhhddddhhhyyyosso///+oo+//+o+/+o++oosyyss``````");
System.Console.WriteLine("`````````````/hddhhhhhhyyysyyhhhsssosysyhhhhhhhhyyyhhhhhddddhhyyyysoooo/::++++//oo+/+o+++oosys.`````");
System.Console.WriteLine("```````````./hhhhhsyhhhyyysyyyyso++::/:/yyyyyyyhhhyhhhhhhdddhhhyyyso+ooo+//+++/:/++++oo+/+ooso-`````");
System.Console.WriteLine("```````./+shhyyhhhyhyssyhhhyyyys+/:-syyooyyyyyyhhhhhhdhhhhdddhhyhooo++oo+++++++/:/+o++o+/+oooo.`````");
System.Console.WriteLine("```````-yhhhyyhyysyyhddhysosooso+//syhyyyyyysshyyyyhhddhyssyyhdhhyso+++oo+++oo++//+oo+o++++oo+``````");
System.Console.WriteLine("````````yyyysysooshyhhoosss+:-````.`+//`so:.`.yyyshshhyyhsossyddhho:.``.+-./ssooo+++o++o+++oo:``````");
System.Console.WriteLine("````````..-::...-oosy//+o/.```````````.`/````-yhyhhohhyyhsssyhhdhy:``````:``.o+.:o++oo+o+++oo-``````");
System.Console.WriteLine("````````````.`./yoyo:::-`````````````````````-h:yssooosyssyhhdddhys-``````````+.`.+osso++++oo/``````");
System.Console.WriteLine("````````````./+yys+-.```````````````````````.-.+yyhs+oosysyhhhhyy+/:```````````````oo-soosooo+``````");
System.Console.WriteLine("`````````````+sso+.````````````````````````````-ohhysoosyhyhdddhs-`````````````````.o`-sossoo+``````");
System.Console.WriteLine("``````````````....`````````````````````````````-ohdhyyoosyhddddy///````````````````````:ys:so+``````");
System.Console.WriteLine("```````````````````````````````````````````````-+so+-:o++osdddhh++-`````````````````````ss:+o/``````");
System.Console.WriteLine("````````````````````````````````````````````````--``````:+sshhdh/..`````````````````````/s//s.``````");
System.Console.WriteLine("`````````````````````````````````````````````````````````/++sydhyo-`````````````````````/y--o```````");
System.Console.WriteLine("`````````````````````````````````````````````````````````./++shhs::.````````````````````so`/-```````");
System.Console.WriteLine("``````````````````````````````````````````````````````````:++ohhyo-````````````````````-y.`o````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````-++shhy:/````````````````````+-`-:````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````.++shho+````````````````````.-``-`````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````.++yhy-:``````````````````````````````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````-+shhs:```````````````````````````````````");
System.Console.WriteLine("`````````````````````````````````````````````````````````-+odhy/.```````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````:+odh++`````````````````````````````````````");
System.Console.WriteLine("```````````````````````````````.:o:..-.``````````````.-+shdsy.``````````````````````````````````````");
System.Console.WriteLine("`````````````````````````````.:oyyyysyyooo/+/-...`.-/oshhs/..```````````````````````````````````````");
System.Console.WriteLine("```````````````````````````./osyyyhhhyhhyhyyssysoosyhhs/:```````````````````````````````````````````");
System.Console.WriteLine("``````````````````````````:syyhhhhdo-:/osssssoyysos:--``````````````````````````````````````````````");
System.Console.WriteLine("`````````````````````````/yhhhyyyyys:-````.``-..````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````:so+::.`````..``````````````````````````````````````````````````````````````");
System.Console.WriteLine("```````````````````````-o.``````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("```````````````````````.````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
SparringMatch(me,Marcus);
System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem2 = System.Console.ReadLine().ToLower();
    
    if(UseItem2 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
     if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }
       }
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();






    System.Console.WriteLine("You notice a wall in front of you with only a path to the left");
    System.Console.WriteLine("You take that path..");
    me.MoveWest();
System.Console.WriteLine("                                             ..--://+++.                                            ");
System.Console.WriteLine("                                             .-:/++osyy`                                            ");
System.Console.WriteLine("                                             ..-/+ossyo                                             ");
System.Console.WriteLine("                                           ``.-:+osyyyo```                                          ");
System.Console.WriteLine("                                          .``..+syhdddy:..                                          ");
System.Console.WriteLine("                                          .`...+osyhhhs:.-                                          ");
System.Console.WriteLine("                                          ....-+ooyyyy+/.-                                          ");
System.Console.WriteLine("                                           ..-/ssyyhhy/:.`                                          ");
System.Console.WriteLine("                                           `..-::/:/ooooo/                                          ");
System.Console.WriteLine("                                         `-:-::+o:+shyss+                                           ");
System.Console.WriteLine("                                        `:///////ooosy+/-                                           ");
System.Console.WriteLine("                                          `-+oo/o+:+hhyys++                                         ");
System.Console.WriteLine("                                         ``.-::://:oo.-+o:                                          ");
System.Console.WriteLine("                                           ``.---:o:`:+o`                                           ");
System.Console.WriteLine("                                               ` -++`+++                                            ");
System.Console.WriteLine("                                                `` .+o`oo/                                          ");
System.Console.WriteLine("                                                ````/o`oo/                                          ");
System.Console.WriteLine("                                                ````:o-+o+                                          ");
System.Console.WriteLine("                                                ````:o:/oo                                          ");
System.Console.WriteLine("                                                ````.-`-+o`                                         ");
System.Console.WriteLine("                                           `    ````````:o-                                         ");
System.Console.WriteLine("                                           `   `````````-++                                         ");
System.Console.WriteLine("                                          .`   ``````..../-                                         ");
System.Console.WriteLine("                                         ``.`....````......`                                        ");
System.Console.WriteLine("                                       `.....`````````..``..``                                      ");
System.Console.WriteLine("                                     ``....``.```.....``````..``                                    ");
System.Console.WriteLine("                                  ``..--::::://::::::::::---.....`                                  ");
System.Console.WriteLine("                                 :++///////////::::::///////:://++/`                                ");
System.Console.WriteLine("                                :syo/:/ooooooo+++/////++ooooosssyys+`                               ");
System.Console.WriteLine("                               -oy+-.-:+++ssyysoo+++++ossyysssyyysso:                               ");
System.Console.WriteLine("                               +oo-.-:/:-:/oyysoooooooosssyysssyyyys+`                              ");
System.Console.WriteLine("                              `+s/..-/:---/syyyyyyyyyyyyyyyyyssssysso-                              ");
System.Console.WriteLine("                              .+s+::/+:--:+hhhhhhhhhhhhhhhhyyyyssssso-                              ");
System.Console.WriteLine("                              .+oo++oo+//+yhddddddddhdddddddyysssssso-                              ");
System.Console.WriteLine("                              .+ooosssyyyyhdmmdddmddmmdmdmdddhyssssoo-                              ");
System.Console.WriteLine("                              `+osssshdddddmmmmmdmmmmmmmmddmdddhsssso-                              ");
System.Console.WriteLine("                              `/oosyhmmmmmmmmmmmmmmmmmmmmmmmmmmdyysso.                              ");
System.Console.WriteLine("                               -+ssydddmmmmmmmmmmmmmmmmmmmmmmmmdhyys+`                              ");
System.Console.WriteLine("                               `/osyddddddmmmmmmmmmmmmmmmmmmmmdddhyo-                               ");
System.Console.WriteLine("                               `./osyddddmmmmmmmmmmmmmmmmmmmmmddhys:``                              ");
System.Console.WriteLine("                               ``./+oyhdddmmmmmmmmmmmmmmmmmmddhhys/-.``                             ");
System.Console.WriteLine("                               ``.-:/osyyhhhddddddddddddddddhdhys+:-.``                             ");
System.Console.WriteLine("                                ``..--:/+osyyhhhdddddddddhhyso+/:--.``                              ");
System.Console.WriteLine("                                  ````.....----:::::::::::----....```                               ");
System.Console.WriteLine("                                     `````````````````````````````                                  ");
 System.Console.WriteLine("In this room you discovered a armor potion! Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No]");
 int pickup2 = Convert.ToInt32(Console.ReadLine());
 if(pickup2 == 1)
    {
       inventory.Add(P2);
       System.Console.WriteLine("You added a armor potion to your inventory");
    }
  if(pickup2 == 2)
  {
     System.Console.WriteLine("You left the potion to itself and continue your journey");

     }
  System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem3 = System.Console.ReadLine().ToLower();
    
    if(UseItem3 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
     if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }
       }   
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();

    System.Console.WriteLine("You notice there is only a single hallway leading up.");
    System.Console.WriteLine("You take that path..");
    me.MoveNorth();
  }
  if(HallWayChoice2 == "left")
  {
    System.Console.WriteLine("You take the path on the left");
    me.MoveWest();
System.Console.WriteLine("In this room you encounter a drake. you have no choice but to fight for your life!");    
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````.---------.`````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````---:/+yssyy+.```````````````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````````````````:/:/dhhhhhso:`````````````````");
System.Console.WriteLine("````````````````....---.```````````````````````````````````````````````syydhddhhhhys.```````````````");
System.Console.WriteLine("```````````````://+syys+:.````````````````````````````````````````````:hhhhhhhdddddhy.``````````````");
System.Console.WriteLine("```````````````.```-ssysss/.`````````````````````````````````````````/hhddhhhhhddhhdhs.`````````````");
System.Console.WriteLine("````````````````````ossyssso-``````-``.`.:.````````````````````````-yhhddhhhhhhyhhhhhho.````````````");
System.Console.WriteLine("````````````````````-yyyyyooo+/:::+o.-oo+-`.://:.```````````````-:/hmhddhhhhyyyyyyhhhyho````````````");
System.Console.WriteLine("````````````````````-ossyyyyyyyyyhshyshh++oo/::///:.````````````-ysshddhhhyyhysyhyyyyyyy+```````````");
System.Console.WriteLine("```````````````````.../+ssssyyyshyhddhdhhhhysyh+-.--::-.```````-yhyyhhyyyyysyyyssyysyyyys/``````````");
System.Console.WriteLine("``````````````````````/:-sooyyysdhhhhdhhhhhhhyysosys+::-.`````-yyyhhyyyyssyyssyyssssoyyyso-`````````");
System.Console.WriteLine("`````````````````````:o+.osy/yyhysydddhhyyhyyyyyyyysooso+/-`./hyyyhyssysssosssosysosssyyyso-````````");
System.Console.WriteLine("`````````````````````oh+shhdhhhyyhhhyhhyyyyyssshyyysyhyy/--/yhhhhhhso+oossooosoossoosssyyyos````````");
System.Console.WriteLine("```````````````````-+hdhhddhhddddhyyyyyyyyssyyyysshhhdddhhhhhdhhhhhyo++ooooo+sso+osooooosyys/```````");
System.Console.WriteLine("`````````````````//yhhhhhhdyddhhhhyyhhhyyysyhyssooyyyhhhddddddhhysyys+/++sso+/oo++ooo+oooyysy-``````");
System.Console.WriteLine("``````````````:+sddhdhhshhhhhdddy++oyhhhhyyyhhysssyhyhhhddddhhhyyyosso///+oo+//+o+/+o++oosyyss``````");
System.Console.WriteLine("`````````````/hddhhhhhhyyysyyhhhsssosysyhhhhhhhhyyyhhhhhddddhhyyyysoooo/::++++//oo+/+o+++oosys.`````");
System.Console.WriteLine("```````````./hhhhhsyhhhyyysyyyyso++::/:/yyyyyyyhhhyhhhhhhdddhhhyyyso+ooo+//+++/:/++++oo+/+ooso-`````");
System.Console.WriteLine("```````./+shhyyhhhyhyssyhhhyyyys+/:-syyooyyyyyyhhhhhhdhhhhdddhhyhooo++oo+++++++/:/+o++o+/+oooo.`````");
System.Console.WriteLine("```````-yhhhyyhyysyyhddhysosooso+//syhyyyyyysshyyyyhhddhyssyyhdhhyso+++oo+++oo++//+oo+o++++oo+``````");
System.Console.WriteLine("````````yyyysysooshyhhoosss+:-````.`+//`so:.`.yyyshshhyyhsossyddhho:.``.+-./ssooo+++o++o+++oo:``````");
System.Console.WriteLine("````````..-::...-oosy//+o/.```````````.`/````-yhyhhohhyyhsssyhhdhy:``````:``.o+.:o++oo+o+++oo-``````");
System.Console.WriteLine("````````````.`./yoyo:::-`````````````````````-h:yssooosyssyhhdddhys-``````````+.`.+osso++++oo/``````");
System.Console.WriteLine("````````````./+yys+-.```````````````````````.-.+yyhs+oosysyhhhhyy+/:```````````````oo-soosooo+``````");
System.Console.WriteLine("`````````````+sso+.````````````````````````````-ohhysoosyhyhdddhs-`````````````````.o`-sossoo+``````");
System.Console.WriteLine("``````````````....`````````````````````````````-ohdhyyoosyhddddy///````````````````````:ys:so+``````");
System.Console.WriteLine("```````````````````````````````````````````````-+so+-:o++osdddhh++-`````````````````````ss:+o/``````");
System.Console.WriteLine("````````````````````````````````````````````````--``````:+sshhdh/..`````````````````````/s//s.``````");
System.Console.WriteLine("`````````````````````````````````````````````````````````/++sydhyo-`````````````````````/y--o```````");
System.Console.WriteLine("`````````````````````````````````````````````````````````./++shhs::.````````````````````so`/-```````");
System.Console.WriteLine("``````````````````````````````````````````````````````````:++ohhyo-````````````````````-y.`o````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````-++shhy:/````````````````````+-`-:````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````.++shho+````````````````````.-``-`````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````.++yhy-:``````````````````````````````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````-+shhs:```````````````````````````````````");
System.Console.WriteLine("`````````````````````````````````````````````````````````-+odhy/.```````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````:+odh++`````````````````````````````````````");
System.Console.WriteLine("```````````````````````````````.:o:..-.``````````````.-+shdsy.``````````````````````````````````````");
System.Console.WriteLine("`````````````````````````````.:oyyyysyyooo/+/-...`.-/oshhs/..```````````````````````````````````````");
System.Console.WriteLine("```````````````````````````./osyyyhhhyhhyhyyssysoosyhhs/:```````````````````````````````````````````");
System.Console.WriteLine("``````````````````````````:syyhhhhdo-:/osssssoyysos:--``````````````````````````````````````````````");
System.Console.WriteLine("`````````````````````````/yhhhyyyyys:-````.``-..````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````:so+::.`````..``````````````````````````````````````````````````````````````");
System.Console.WriteLine("```````````````````````-o.``````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("```````````````````````.````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
SparringMatch(me,Toothless);  
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();






    System.Console.WriteLine("You notice a hallway going straight, and another hallway going to your left.");
    System.Console.WriteLine("Which way do you choose to go?");
    System.Console.WriteLine("[Enter up to go up] or [Enter left to go left]");
    string HallWayChoice3 = System.Console.ReadLine().ToLower();
      if(HallWayChoice3 == "up")
     {
       System.Console.WriteLine("You take the path up");
      me.MoveNorth();
System.Console.WriteLine("                                             ..--://+++.                                            ");
System.Console.WriteLine("                                             .-:/++osyy`                                            ");
System.Console.WriteLine("                                             ..-/+ossyo                                             ");
System.Console.WriteLine("                                           ``.-:+osyyyo```                                          ");
System.Console.WriteLine("                                          .``..+syhdddy:..                                          ");
System.Console.WriteLine("                                          .`...+osyhhhs:.-                                          ");
System.Console.WriteLine("                                          ....-+ooyyyy+/.-                                          ");
System.Console.WriteLine("                                           ..-/ssyyhhy/:.`                                          ");
System.Console.WriteLine("                                           `..-::/:/ooooo/                                          ");
System.Console.WriteLine("                                         `-:-::+o:+shyss+                                           ");
System.Console.WriteLine("                                        `:///////ooosy+/-                                           ");
System.Console.WriteLine("                                          `-+oo/o+:+hhyys++                                         ");
System.Console.WriteLine("                                         ``.-::://:oo.-+o:                                          ");
System.Console.WriteLine("                                           ``.---:o:`:+o`                                           ");
System.Console.WriteLine("                                               ` -++`+++                                            ");
System.Console.WriteLine("                                                `` .+o`oo/                                          ");
System.Console.WriteLine("                                                ````/o`oo/                                          ");
System.Console.WriteLine("                                                ````:o-+o+                                          ");
System.Console.WriteLine("                                                ````:o:/oo                                          ");
System.Console.WriteLine("                                                ````.-`-+o`                                         ");
System.Console.WriteLine("                                           `    ````````:o-                                         ");
System.Console.WriteLine("                                           `   `````````-++                                         ");
System.Console.WriteLine("                                          .`   ``````..../-                                         ");
System.Console.WriteLine("                                         ``.`....````......`                                        ");
System.Console.WriteLine("                                       `.....`````````..``..``                                      ");
System.Console.WriteLine("                                     ``....``.```.....``````..``                                    ");
System.Console.WriteLine("                                  ``..--::::://::::::::::---.....`                                  ");
System.Console.WriteLine("                                 :++///////////::::::///////:://++/`                                ");
System.Console.WriteLine("                                :syo/:/ooooooo+++/////++ooooosssyys+`                               ");
System.Console.WriteLine("                               -oy+-.-:+++ssyysoo+++++ossyysssyyysso:                               ");
System.Console.WriteLine("                               +oo-.-:/:-:/oyysoooooooosssyysssyyyys+`                              ");
System.Console.WriteLine("                              `+s/..-/:---/syyyyyyyyyyyyyyyyyssssysso-                              ");
System.Console.WriteLine("                              .+s+::/+:--:+hhhhhhhhhhhhhhhhyyyyssssso-                              ");
System.Console.WriteLine("                              .+oo++oo+//+yhddddddddhdddddddyysssssso-                              ");
System.Console.WriteLine("                              .+ooosssyyyyhdmmdddmddmmdmdmdddhyssssoo-                              ");
System.Console.WriteLine("                              `+osssshdddddmmmmmdmmmmmmmmddmdddhsssso-                              ");
System.Console.WriteLine("                              `/oosyhmmmmmmmmmmmmmmmmmmmmmmmmmmdyysso.                              ");
System.Console.WriteLine("                               -+ssydddmmmmmmmmmmmmmmmmmmmmmmmmdhyys+`                              ");
System.Console.WriteLine("                               `/osyddddddmmmmmmmmmmmmmmmmmmmmdddhyo-                               ");
System.Console.WriteLine("                               `./osyddddmmmmmmmmmmmmmmmmmmmmmddhys:``                              ");
System.Console.WriteLine("                               ``./+oyhdddmmmmmmmmmmmmmmmmmmddhhys/-.``                             ");
System.Console.WriteLine("                               ``.-:/osyyhhhddddddddddddddddhdhys+:-.``                             ");
System.Console.WriteLine("                                ``..--:/+osyyhhhdddddddddhhyso+/:--.``                              ");
System.Console.WriteLine("                                  ````.....----:::::::::::----....```                               ");
System.Console.WriteLine("                                     `````````````````````````````                                  ");
 System.Console.WriteLine("In this room you discovered a armor potion! Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No]");
 int pickup3 = Convert.ToInt32(Console.ReadLine());
 if(pickup3 == 1)
    {
       inventory.Add(P2);
       System.Console.WriteLine("You added a armor potion to your inventory");
    }
  if(pickup3 == 2)
  {
     System.Console.WriteLine("You left the potion to itself and continue your journey");

     }
 System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem4 = System.Console.ReadLine().ToLower();
    
    if(UseItem4 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
     if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }
       }    
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();


      System.Console.WriteLine("You notice there is only a single hallway leading up.");
      System.Console.WriteLine("You take that path..");
      me.MoveNorth();
     }
     if(HallWayChoice3 == "left")
     {
      System.Console.WriteLine("You take the path on the left");
       me.MoveWest();
System.Console.WriteLine("              .ss/.                                                                                 ");
System.Console.WriteLine("            `ohhhhhs/.                                                                              ");
System.Console.WriteLine("           :hddddhhhhho.                                                                            ");
System.Console.WriteLine("          +hdddddddhhy/.                                                                            ");
System.Console.WriteLine("        .yddhhhhhhhhsooo/.                                                                          ");
System.Console.WriteLine("       /ddddhhhhhhhsoossso/`                                                                        ");
System.Console.WriteLine("     .sdddddhhhyyysoooooooo+:`                                                                      ");
System.Console.WriteLine("   `odddddddhhyy+.`-+ooooooo++:`                                                                    ");
System.Console.WriteLine(" .oddddddddhhhy+`    `:+oooo++++:.                                                                  ");
System.Console.WriteLine("-hdddddhhhddhh+         .:+oooo+++/:.                                                               ");
System.Console.WriteLine(" ./yhddhhhhhhs`            .:+oooo+++/:.                                                            ");
System.Console.WriteLine("    ./oyhhhhy.                .:+oooooo+/:.                                                         ");
System.Console.WriteLine("       `.-/+/                    .:+ooooooo+:.`                                                     ");
System.Console.WriteLine("                                    `-/+oooooo+/-`                                                  ");
System.Console.WriteLine("                                       `.:+oooooo+/-.                                               ");
System.Console.WriteLine("                                           `-/oooooo++:.`                                           ");
System.Console.WriteLine("                                              `.:+oooooo+/-`                                        ");
System.Console.WriteLine("                                                  .:+ooooooo+:.`                                    ");
System.Console.WriteLine("                                                    `-/+oooooo+/-`                                  ");
System.Console.WriteLine("                                                        .:+ooossoo+:.                               ");
System.Console.WriteLine("                                                          `-/oossssso/.`                            ");
System.Console.WriteLine("                                                             `.:+ossssso/-`                         ");
System.Console.WriteLine("                                                                 `:+ossssoo/-`                      ");
System.Console.WriteLine("                                                                    `-/oosssoo/-`                   ");
System.Console.WriteLine("                                                                        `./osssoo+/.`               ");
System.Console.WriteLine("                                                                            `./ossooo+:.            ");
System.Console.WriteLine("                                                                               `-/osssoo+:`         ");
System.Console.WriteLine("                                                                                  `-+ssssoo+-`      ");
System.Console.WriteLine("                                                                                     .:ossssoo/.    ");
System.Console.WriteLine("                                                                                       `:ssssssso:` ");
System.Console.WriteLine("                                                                                         .osss+ysss:");
System.Console.WriteLine("                                                                                         `+yyyysso` ");
System.Console.WriteLine("                                                                                            -+oo:.  ");
 System.Console.WriteLine("In this room you discovered a Axe! Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No]");
 int pickup4 = Convert.ToInt32(Console.ReadLine());
 if(pickup4 == 1)
    {
       inventory.Add(P3);
       System.Console.WriteLine("You added an axe to your inventory");
    }
  if(pickup4 == 2)
    {
      System.Console.WriteLine("You left the axe to itself and continue your journey");

      }
System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem5 = System.Console.ReadLine().ToLower();
    
    if(UseItem5 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
     if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }
       }      
 System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();


      System.Console.WriteLine("You notice there is only a single hallway leading to the right.");
      System.Console.WriteLine("You take that path..");
      me.MoveEast();
System.Console.WriteLine("                                             ..--://+++.                                            ");
System.Console.WriteLine("                                             .-:/++osyy`                                            ");
System.Console.WriteLine("                                             ..-/+ossyo                                             ");
System.Console.WriteLine("                                           ``.-:+osyyyo```                                          ");
System.Console.WriteLine("                                          .``..+syhdddy:..                                          ");
System.Console.WriteLine("                                          .`...+osyhhhs:.-                                          ");
System.Console.WriteLine("                                          ....-+ooyyyy+/.-                                          ");
System.Console.WriteLine("                                           ..-/ssyyhhy/:.`                                          ");
System.Console.WriteLine("                                           `..-::/:/ooooo/                                          ");
System.Console.WriteLine("                                         `-:-::+o:+shyss+                                           ");
System.Console.WriteLine("                                        `:///////ooosy+/-                                           ");
System.Console.WriteLine("                                          `-+oo/o+:+hhyys++                                         ");
System.Console.WriteLine("                                         ``.-::://:oo.-+o:                                          ");
System.Console.WriteLine("                                           ``.---:o:`:+o`                                           ");
System.Console.WriteLine("                                               ` -++`+++                                            ");
System.Console.WriteLine("                                                `` .+o`oo/                                          ");
System.Console.WriteLine("                                                ````/o`oo/                                          ");
System.Console.WriteLine("                                                ````:o-+o+                                          ");
System.Console.WriteLine("                                                ````:o:/oo                                          ");
System.Console.WriteLine("                                                ````.-`-+o`                                         ");
System.Console.WriteLine("                                           `    ````````:o-                                         ");
System.Console.WriteLine("                                           `   `````````-++                                         ");
System.Console.WriteLine("                                          .`   ``````..../-                                         ");
System.Console.WriteLine("                                         ``.`....````......`                                        ");
System.Console.WriteLine("                                       `.....`````````..``..``                                      ");
System.Console.WriteLine("                                     ``....``.```.....``````..``                                    ");
System.Console.WriteLine("                                  ``..--::::://::::::::::---.....`                                  ");
System.Console.WriteLine("                                 :++///////////::::::///////:://++/`                                ");
System.Console.WriteLine("                                :syo/:/ooooooo+++/////++ooooosssyys+`                               ");
System.Console.WriteLine("                               -oy+-.-:+++ssyysoo+++++ossyysssyyysso:                               ");
System.Console.WriteLine("                               +oo-.-:/:-:/oyysoooooooosssyysssyyyys+`                              ");
System.Console.WriteLine("                              `+s/..-/:---/syyyyyyyyyyyyyyyyyssssysso-                              ");
System.Console.WriteLine("                              .+s+::/+:--:+hhhhhhhhhhhhhhhhyyyyssssso-                              ");
System.Console.WriteLine("                              .+oo++oo+//+yhddddddddhdddddddyysssssso-                              ");
System.Console.WriteLine("                              .+ooosssyyyyhdmmdddmddmmdmdmdddhyssssoo-                              ");
System.Console.WriteLine("                              `+osssshdddddmmmmmdmmmmmmmmddmdddhsssso-                              ");
System.Console.WriteLine("                              `/oosyhmmmmmmmmmmmmmmmmmmmmmmmmmmdyysso.                              ");
System.Console.WriteLine("                               -+ssydddmmmmmmmmmmmmmmmmmmmmmmmmdhyys+`                              ");
System.Console.WriteLine("                               `/osyddddddmmmmmmmmmmmmmmmmmmmmdddhyo-                               ");
System.Console.WriteLine("                               `./osyddddmmmmmmmmmmmmmmmmmmmmmddhys:``                              ");
System.Console.WriteLine("                               ``./+oyhdddmmmmmmmmmmmmmmmmmmddhhys/-.``                             ");
System.Console.WriteLine("                               ``.-:/osyyhhhddddddddddddddddhdhys+:-.``                             ");
System.Console.WriteLine("                                ``..--:/+osyyhhhdddddddddhhyso+/:--.``                              ");
System.Console.WriteLine("                                  ````.....----:::::::::::----....```                               ");
System.Console.WriteLine("                                     `````````````````````````````                                  ");
 System.Console.WriteLine("In this room you discovered a armor potion! Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No]");
 int pickup5 = Convert.ToInt32(Console.ReadLine());
 if(pickup5 == 1)
    {
       inventory.Add(P2);
       System.Console.WriteLine("You added a armor potion to your inventory");
    }
  if(pickup5 == 2)
  {
     System.Console.WriteLine("You left the potion to itself and continue your journey");

     }
System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem6 = System.Console.ReadLine().ToLower();
    
    if(UseItem6 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
     if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }
       }     
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();

      System.Console.WriteLine("You notice there is only a single hallway leading up.");
      System.Console.WriteLine("You take that path..");
       me.MoveNorth();
     }

  }

}


if (HallWayChoice == "left")
{
  System.Console.WriteLine("You go left.");
  me.MoveWest();
  System.Console.WriteLine("You notice a hallway going straight, and another hallway going to your left.");
  System.Console.WriteLine("Which way do you choose to go?");
   System.Console.WriteLine("[Enter up to go up] or [Enter left to go left]");
   string HallWayChoice4 = System.Console.ReadLine().ToLower();

  if(HallWayChoice4 == "up")
  {
    System.Console.WriteLine("You go up.");
    me.MoveNorth();
System.Console.WriteLine("In this room you encounter a drake. you have no choice but to fight for your life!");    
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````.---------.`````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````---:/+yssyy+.```````````````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````````````````:/:/dhhhhhso:`````````````````");
System.Console.WriteLine("````````````````....---.```````````````````````````````````````````````syydhddhhhhys.```````````````");
System.Console.WriteLine("```````````````://+syys+:.````````````````````````````````````````````:hhhhhhhdddddhy.``````````````");
System.Console.WriteLine("```````````````.```-ssysss/.`````````````````````````````````````````/hhddhhhhhddhhdhs.`````````````");
System.Console.WriteLine("````````````````````ossyssso-``````-``.`.:.````````````````````````-yhhddhhhhhhyhhhhhho.````````````");
System.Console.WriteLine("````````````````````-yyyyyooo+/:::+o.-oo+-`.://:.```````````````-:/hmhddhhhhyyyyyyhhhyho````````````");
System.Console.WriteLine("````````````````````-ossyyyyyyyyyhshyshh++oo/::///:.````````````-ysshddhhhyyhysyhyyyyyyy+```````````");
System.Console.WriteLine("```````````````````.../+ssssyyyshyhddhdhhhhysyh+-.--::-.```````-yhyyhhyyyyysyyyssyysyyyys/``````````");
System.Console.WriteLine("``````````````````````/:-sooyyysdhhhhdhhhhhhhyysosys+::-.`````-yyyhhyyyyssyyssyyssssoyyyso-`````````");
System.Console.WriteLine("`````````````````````:o+.osy/yyhysydddhhyyhyyyyyyyysooso+/-`./hyyyhyssysssosssosysosssyyyso-````````");
System.Console.WriteLine("`````````````````````oh+shhdhhhyyhhhyhhyyyyyssshyyysyhyy/--/yhhhhhhso+oossooosoossoosssyyyos````````");
System.Console.WriteLine("```````````````````-+hdhhddhhddddhyyyyyyyyssyyyysshhhdddhhhhhdhhhhhyo++ooooo+sso+osooooosyys/```````");
System.Console.WriteLine("`````````````````//yhhhhhhdyddhhhhyyhhhyyysyhyssooyyyhhhddddddhhysyys+/++sso+/oo++ooo+oooyysy-``````");
System.Console.WriteLine("``````````````:+sddhdhhshhhhhdddy++oyhhhhyyyhhysssyhyhhhddddhhhyyyosso///+oo+//+o+/+o++oosyyss``````");
System.Console.WriteLine("`````````````/hddhhhhhhyyysyyhhhsssosysyhhhhhhhhyyyhhhhhddddhhyyyysoooo/::++++//oo+/+o+++oosys.`````");
System.Console.WriteLine("```````````./hhhhhsyhhhyyysyyyyso++::/:/yyyyyyyhhhyhhhhhhdddhhhyyyso+ooo+//+++/:/++++oo+/+ooso-`````");
System.Console.WriteLine("```````./+shhyyhhhyhyssyhhhyyyys+/:-syyooyyyyyyhhhhhhdhhhhdddhhyhooo++oo+++++++/:/+o++o+/+oooo.`````");
System.Console.WriteLine("```````-yhhhyyhyysyyhddhysosooso+//syhyyyyyysshyyyyhhddhyssyyhdhhyso+++oo+++oo++//+oo+o++++oo+``````");
System.Console.WriteLine("````````yyyysysooshyhhoosss+:-````.`+//`so:.`.yyyshshhyyhsossyddhho:.``.+-./ssooo+++o++o+++oo:``````");
System.Console.WriteLine("````````..-::...-oosy//+o/.```````````.`/````-yhyhhohhyyhsssyhhdhy:``````:``.o+.:o++oo+o+++oo-``````");
System.Console.WriteLine("````````````.`./yoyo:::-`````````````````````-h:yssooosyssyhhdddhys-``````````+.`.+osso++++oo/``````");
System.Console.WriteLine("````````````./+yys+-.```````````````````````.-.+yyhs+oosysyhhhhyy+/:```````````````oo-soosooo+``````");
System.Console.WriteLine("`````````````+sso+.````````````````````````````-ohhysoosyhyhdddhs-`````````````````.o`-sossoo+``````");
System.Console.WriteLine("``````````````....`````````````````````````````-ohdhyyoosyhddddy///````````````````````:ys:so+``````");
System.Console.WriteLine("```````````````````````````````````````````````-+so+-:o++osdddhh++-`````````````````````ss:+o/``````");
System.Console.WriteLine("````````````````````````````````````````````````--``````:+sshhdh/..`````````````````````/s//s.``````");
System.Console.WriteLine("`````````````````````````````````````````````````````````/++sydhyo-`````````````````````/y--o```````");
System.Console.WriteLine("`````````````````````````````````````````````````````````./++shhs::.````````````````````so`/-```````");
System.Console.WriteLine("``````````````````````````````````````````````````````````:++ohhyo-````````````````````-y.`o````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````-++shhy:/````````````````````+-`-:````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````.++shho+````````````````````.-``-`````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````.++yhy-:``````````````````````````````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````-+shhs:```````````````````````````````````");
System.Console.WriteLine("`````````````````````````````````````````````````````````-+odhy/.```````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````:+odh++`````````````````````````````````````");
System.Console.WriteLine("```````````````````````````````.:o:..-.``````````````.-+shdsy.``````````````````````````````````````");
System.Console.WriteLine("`````````````````````````````.:oyyyysyyooo/+/-...`.-/oshhs/..```````````````````````````````````````");
System.Console.WriteLine("```````````````````````````./osyyyhhhyhhyhyyssysoosyhhs/:```````````````````````````````````````````");
System.Console.WriteLine("``````````````````````````:syyhhhhdo-:/osssssoyysos:--``````````````````````````````````````````````");
System.Console.WriteLine("`````````````````````````/yhhhyyyyys:-````.``-..````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````:so+::.`````..``````````````````````````````````````````````````````````````");
System.Console.WriteLine("```````````````````````-o.``````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("```````````````````````.````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
SparringMatch(me,Toothless); 
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();





    System.Console.WriteLine("You notice a hallway going left, and another hallway going to your right.");
    System.Console.WriteLine("Which way do you choose to go?");
    System.Console.WriteLine("[Enter right to go right] or [Enter left to go left]");
    string HallWayChoice5 = System.Console.ReadLine().ToLower();
    if(HallWayChoice5 == "left")
    {
        System.Console.WriteLine("You go left.");
        me.MoveWest();
System.Console.WriteLine("              .ss/.                                                                                 ");
System.Console.WriteLine("            `ohhhhhs/.                                                                              ");
System.Console.WriteLine("           :hddddhhhhho.                                                                            ");
System.Console.WriteLine("          +hdddddddhhy/.                                                                            ");
System.Console.WriteLine("        .yddhhhhhhhhsooo/.                                                                          ");
System.Console.WriteLine("       /ddddhhhhhhhsoossso/`                                                                        ");
System.Console.WriteLine("     .sdddddhhhyyysoooooooo+:`                                                                      ");
System.Console.WriteLine("   `odddddddhhyy+.`-+ooooooo++:`                                                                    ");
System.Console.WriteLine(" .oddddddddhhhy+`    `:+oooo++++:.                                                                  ");
System.Console.WriteLine("-hdddddhhhddhh+         .:+oooo+++/:.                                                               ");
System.Console.WriteLine(" ./yhddhhhhhhs`            .:+oooo+++/:.                                                            ");
System.Console.WriteLine("    ./oyhhhhy.                .:+oooooo+/:.                                                         ");
System.Console.WriteLine("       `.-/+/                    .:+ooooooo+:.`                                                     ");
System.Console.WriteLine("                                    `-/+oooooo+/-`                                                  ");
System.Console.WriteLine("                                       `.:+oooooo+/-.                                               ");
System.Console.WriteLine("                                           `-/oooooo++:.`                                           ");
System.Console.WriteLine("                                              `.:+oooooo+/-`                                        ");
System.Console.WriteLine("                                                  .:+ooooooo+:.`                                    ");
System.Console.WriteLine("                                                    `-/+oooooo+/-`                                  ");
System.Console.WriteLine("                                                        .:+ooossoo+:.                               ");
System.Console.WriteLine("                                                          `-/oossssso/.`                            ");
System.Console.WriteLine("                                                             `.:+ossssso/-`                         ");
System.Console.WriteLine("                                                                 `:+ossssoo/-`                      ");
System.Console.WriteLine("                                                                    `-/oosssoo/-`                   ");
System.Console.WriteLine("                                                                        `./osssoo+/.`               ");
System.Console.WriteLine("                                                                            `./ossooo+:.            ");
System.Console.WriteLine("                                                                               `-/osssoo+:`         ");
System.Console.WriteLine("                                                                                  `-+ssssoo+-`      ");
System.Console.WriteLine("                                                                                     .:ossssoo/.    ");
System.Console.WriteLine("                                                                                       `:ssssssso:` ");
System.Console.WriteLine("                                                                                         .osss+ysss:");
System.Console.WriteLine("                                                                                         `+yyyysso` ");
System.Console.WriteLine("                                                                                            -+oo:.  ");
 System.Console.WriteLine("In this room you discovered a Axe! Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No]");
 int pickup6 = Convert.ToInt32(Console.ReadLine());
 if(pickup6 == 1)
    {
       inventory.Add(P3);
       System.Console.WriteLine("You added an axe to your inventory");
    }
  if(pickup6 == 2)
    {
      System.Console.WriteLine("You left the axe to itself and continue your journey");

      }
System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem7 = System.Console.ReadLine().ToLower();
    
    if(UseItem7 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
     if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }
       }      
 System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();

        System.Console.WriteLine("You notice there is only a single hallway leading up.");
        System.Console.WriteLine("You take that path..");
        me.MoveNorth();
        System.Console.WriteLine("You notice there is only a single hallway leading right.");
        System.Console.WriteLine("You take that path..");
        me.MoveEast();
System.Console.WriteLine("                                             ..--://+++.                                            ");
System.Console.WriteLine("                                             .-:/++osyy`                                            ");
System.Console.WriteLine("                                             ..-/+ossyo                                             ");
System.Console.WriteLine("                                           ``.-:+osyyyo```                                          ");
System.Console.WriteLine("                                          .``..+syhdddy:..                                          ");
System.Console.WriteLine("                                          .`...+osyhhhs:.-                                          ");
System.Console.WriteLine("                                          ....-+ooyyyy+/.-                                          ");
System.Console.WriteLine("                                           ..-/ssyyhhy/:.`                                          ");
System.Console.WriteLine("                                           `..-::/:/ooooo/                                          ");
System.Console.WriteLine("                                         `-:-::+o:+shyss+                                           ");
System.Console.WriteLine("                                        `:///////ooosy+/-                                           ");
System.Console.WriteLine("                                          `-+oo/o+:+hhyys++                                         ");
System.Console.WriteLine("                                         ``.-::://:oo.-+o:                                          ");
System.Console.WriteLine("                                           ``.---:o:`:+o`                                           ");
System.Console.WriteLine("                                               ` -++`+++                                            ");
System.Console.WriteLine("                                                `` .+o`oo/                                          ");
System.Console.WriteLine("                                                ````/o`oo/                                          ");
System.Console.WriteLine("                                                ````:o-+o+                                          ");
System.Console.WriteLine("                                                ````:o:/oo                                          ");
System.Console.WriteLine("                                                ````.-`-+o`                                         ");
System.Console.WriteLine("                                           `    ````````:o-                                         ");
System.Console.WriteLine("                                           `   `````````-++                                         ");
System.Console.WriteLine("                                          .`   ``````..../-                                         ");
System.Console.WriteLine("                                         ``.`....````......`                                        ");
System.Console.WriteLine("                                       `.....`````````..``..``                                      ");
System.Console.WriteLine("                                     ``....``.```.....``````..``                                    ");
System.Console.WriteLine("                                  ``..--::::://::::::::::---.....`                                  ");
System.Console.WriteLine("                                 :++///////////::::::///////:://++/`                                ");
System.Console.WriteLine("                                :syo/:/ooooooo+++/////++ooooosssyys+`                               ");
System.Console.WriteLine("                               -oy+-.-:+++ssyysoo+++++ossyysssyyysso:                               ");
System.Console.WriteLine("                               +oo-.-:/:-:/oyysoooooooosssyysssyyyys+`                              ");
System.Console.WriteLine("                              `+s/..-/:---/syyyyyyyyyyyyyyyyyssssysso-                              ");
System.Console.WriteLine("                              .+s+::/+:--:+hhhhhhhhhhhhhhhhyyyyssssso-                              ");
System.Console.WriteLine("                              .+oo++oo+//+yhddddddddhdddddddyysssssso-                              ");
System.Console.WriteLine("                              .+ooosssyyyyhdmmdddmddmmdmdmdddhyssssoo-                              ");
System.Console.WriteLine("                              `+osssshdddddmmmmmdmmmmmmmmddmdddhsssso-                              ");
System.Console.WriteLine("                              `/oosyhmmmmmmmmmmmmmmmmmmmmmmmmmmdyysso.                              ");
System.Console.WriteLine("                               -+ssydddmmmmmmmmmmmmmmmmmmmmmmmmdhyys+`                              ");
System.Console.WriteLine("                               `/osyddddddmmmmmmmmmmmmmmmmmmmmdddhyo-                               ");
System.Console.WriteLine("                               `./osyddddmmmmmmmmmmmmmmmmmmmmmddhys:``                              ");
System.Console.WriteLine("                               ``./+oyhdddmmmmmmmmmmmmmmmmmmddhhys/-.``                             ");
System.Console.WriteLine("                               ``.-:/osyyhhhddddddddddddddddhdhys+:-.``                             ");
System.Console.WriteLine("                                ``..--:/+osyyhhhdddddddddhhyso+/:--.``                              ");
System.Console.WriteLine("                                  ````.....----:::::::::::----....```                               ");
System.Console.WriteLine("                                     `````````````````````````````                                  ");
 System.Console.WriteLine("In this room you discovered a armor potion! Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No]");
 int pickup7 = Convert.ToInt32(Console.ReadLine());
 if(pickup7 == 1)
    {
       inventory.Add(P2);
       System.Console.WriteLine("You added a armor potion to your inventory");
    }
  if(pickup7 == 2)
  {
     System.Console.WriteLine("You left the potion to itself and continue your journey");

     }
System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem8 = System.Console.ReadLine().ToLower();
    
    if(UseItem8 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
     if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }
       }     
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();


        System.Console.WriteLine("You notice there is only a single hallway leading up.");
        System.Console.WriteLine("You take that path..");
        me.MoveNorth();
    }
    if(HallWayChoice5 == "right")
    {
        System.Console.WriteLine("You go right.");
        me.MoveEast();
System.Console.WriteLine("                                             ..--://+++.                                            ");
System.Console.WriteLine("                                             .-:/++osyy`                                            ");
System.Console.WriteLine("                                             ..-/+ossyo                                             ");
System.Console.WriteLine("                                           ``.-:+osyyyo```                                          ");
System.Console.WriteLine("                                          .``..+syhdddy:..                                          ");
System.Console.WriteLine("                                          .`...+osyhhhs:.-                                          ");
System.Console.WriteLine("                                          ....-+ooyyyy+/.-                                          ");
System.Console.WriteLine("                                           ..-/ssyyhhy/:.`                                          ");
System.Console.WriteLine("                                           `..-::/:/ooooo/                                          ");
System.Console.WriteLine("                                         `-:-::+o:+shyss+                                           ");
System.Console.WriteLine("                                        `:///////ooosy+/-                                           ");
System.Console.WriteLine("                                          `-+oo/o+:+hhyys++                                         ");
System.Console.WriteLine("                                         ``.-::://:oo.-+o:                                          ");
System.Console.WriteLine("                                           ``.---:o:`:+o`                                           ");
System.Console.WriteLine("                                               ` -++`+++                                            ");
System.Console.WriteLine("                                                `` .+o`oo/                                          ");
System.Console.WriteLine("                                                ````/o`oo/                                          ");
System.Console.WriteLine("                                                ````:o-+o+                                          ");
System.Console.WriteLine("                                                ````:o:/oo                                          ");
System.Console.WriteLine("                                                ````.-`-+o`                                         ");
System.Console.WriteLine("                                           `    ````````:o-                                         ");
System.Console.WriteLine("                                           `   `````````-++                                         ");
System.Console.WriteLine("                                          .`   ``````..../-                                         ");
System.Console.WriteLine("                                         ``.`....````......`                                        ");
System.Console.WriteLine("                                       `.....`````````..``..``                                      ");
System.Console.WriteLine("                                     ``....``.```.....``````..``                                    ");
System.Console.WriteLine("                                  ``..--::::://::::::::::---.....`                                  ");
System.Console.WriteLine("                                 :++///////////::::::///////:://++/`                                ");
System.Console.WriteLine("                                :syo/:/ooooooo+++/////++ooooosssyys+`                               ");
System.Console.WriteLine("                               -oy+-.-:+++ssyysoo+++++ossyysssyyysso:                               ");
System.Console.WriteLine("                               +oo-.-:/:-:/oyysoooooooosssyysssyyyys+`                              ");
System.Console.WriteLine("                              `+s/..-/:---/syyyyyyyyyyyyyyyyyssssysso-                              ");
System.Console.WriteLine("                              .+s+::/+:--:+hhhhhhhhhhhhhhhhyyyyssssso-                              ");
System.Console.WriteLine("                              .+oo++oo+//+yhddddddddhdddddddyysssssso-                              ");
System.Console.WriteLine("                              .+ooosssyyyyhdmmdddmddmmdmdmdddhyssssoo-                              ");
System.Console.WriteLine("                              `+osssshdddddmmmmmdmmmmmmmmddmdddhsssso-                              ");
System.Console.WriteLine("                              `/oosyhmmmmmmmmmmmmmmmmmmmmmmmmmmdyysso.                              ");
System.Console.WriteLine("                               -+ssydddmmmmmmmmmmmmmmmmmmmmmmmmdhyys+`                              ");
System.Console.WriteLine("                               `/osyddddddmmmmmmmmmmmmmmmmmmmmdddhyo-                               ");
System.Console.WriteLine("                               `./osyddddmmmmmmmmmmmmmmmmmmmmmddhys:``                              ");
System.Console.WriteLine("                               ``./+oyhdddmmmmmmmmmmmmmmmmmmddhhys/-.``                             ");
System.Console.WriteLine("                               ``.-:/osyyhhhddddddddddddddddhdhys+:-.``                             ");
System.Console.WriteLine("                                ``..--:/+osyyhhhdddddddddhhyso+/:--.``                              ");
System.Console.WriteLine("                                  ````.....----:::::::::::----....```                               ");
System.Console.WriteLine("                                     `````````````````````````````                                  ");
 System.Console.WriteLine("In this room you discovered a potion of healing! Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No]");
 int pickup8 = Convert.ToInt32(Console.ReadLine());
 if(pickup8 == 1)
    {
       inventory.Add(P1);
       System.Console.WriteLine("You added a healing potion to your inventory");
    }
  if(pickup8 ==2)
    {
      System.Console.WriteLine("You left the potion to itself and continue your journey");

      }
 System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem9 = System.Console.ReadLine().ToLower();
    
    if(UseItem9 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
     if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }
       }     
 System.Console.WriteLine("Press any key to continue..."); 
 Console.ReadKey(); 
 System.Console.Clear();

        System.Console.WriteLine("You notice there is only a single hallway leading up.");
        System.Console.WriteLine("You take that path..");
        me.MoveNorth();
System.Console.WriteLine("In this room you encounter a leviathan, you have no choice but to fight for your life!");        
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````.---------.`````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````---:/+yssyy+.```````````````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````````````````:/:/dhhhhhso:`````````````````");
System.Console.WriteLine("````````````````....---.```````````````````````````````````````````````syydhddhhhhys.```````````````");
System.Console.WriteLine("```````````````://+syys+:.````````````````````````````````````````````:hhhhhhhdddddhy.``````````````");
System.Console.WriteLine("```````````````.```-ssysss/.`````````````````````````````````````````/hhddhhhhhddhhdhs.`````````````");
System.Console.WriteLine("````````````````````ossyssso-``````-``.`.:.````````````````````````-yhhddhhhhhhyhhhhhho.````````````");
System.Console.WriteLine("````````````````````-yyyyyooo+/:::+o.-oo+-`.://:.```````````````-:/hmhddhhhhyyyyyyhhhyho````````````");
System.Console.WriteLine("````````````````````-ossyyyyyyyyyhshyshh++oo/::///:.````````````-ysshddhhhyyhysyhyyyyyyy+```````````");
System.Console.WriteLine("```````````````````.../+ssssyyyshyhddhdhhhhysyh+-.--::-.```````-yhyyhhyyyyysyyyssyysyyyys/``````````");
System.Console.WriteLine("``````````````````````/:-sooyyysdhhhhdhhhhhhhyysosys+::-.`````-yyyhhyyyyssyyssyyssssoyyyso-`````````");
System.Console.WriteLine("`````````````````````:o+.osy/yyhysydddhhyyhyyyyyyyysooso+/-`./hyyyhyssysssosssosysosssyyyso-````````");
System.Console.WriteLine("`````````````````````oh+shhdhhhyyhhhyhhyyyyyssshyyysyhyy/--/yhhhhhhso+oossooosoossoosssyyyos````````");
System.Console.WriteLine("```````````````````-+hdhhddhhddddhyyyyyyyyssyyyysshhhdddhhhhhdhhhhhyo++ooooo+sso+osooooosyys/```````");
System.Console.WriteLine("`````````````````//yhhhhhhdyddhhhhyyhhhyyysyhyssooyyyhhhddddddhhysyys+/++sso+/oo++ooo+oooyysy-``````");
System.Console.WriteLine("``````````````:+sddhdhhshhhhhdddy++oyhhhhyyyhhysssyhyhhhddddhhhyyyosso///+oo+//+o+/+o++oosyyss``````");
System.Console.WriteLine("`````````````/hddhhhhhhyyysyyhhhsssosysyhhhhhhhhyyyhhhhhddddhhyyyysoooo/::++++//oo+/+o+++oosys.`````");
System.Console.WriteLine("```````````./hhhhhsyhhhyyysyyyyso++::/:/yyyyyyyhhhyhhhhhhdddhhhyyyso+ooo+//+++/:/++++oo+/+ooso-`````");
System.Console.WriteLine("```````./+shhyyhhhyhyssyhhhyyyys+/:-syyooyyyyyyhhhhhhdhhhhdddhhyhooo++oo+++++++/:/+o++o+/+oooo.`````");
System.Console.WriteLine("```````-yhhhyyhyysyyhddhysosooso+//syhyyyyyysshyyyyhhddhyssyyhdhhyso+++oo+++oo++//+oo+o++++oo+``````");
System.Console.WriteLine("````````yyyysysooshyhhoosss+:-````.`+//`so:.`.yyyshshhyyhsossyddhho:.``.+-./ssooo+++o++o+++oo:``````");
System.Console.WriteLine("````````..-::...-oosy//+o/.```````````.`/````-yhyhhohhyyhsssyhhdhy:``````:``.o+.:o++oo+o+++oo-``````");
System.Console.WriteLine("````````````.`./yoyo:::-`````````````````````-h:yssooosyssyhhdddhys-``````````+.`.+osso++++oo/``````");
System.Console.WriteLine("````````````./+yys+-.```````````````````````.-.+yyhs+oosysyhhhhyy+/:```````````````oo-soosooo+``````");
System.Console.WriteLine("`````````````+sso+.````````````````````````````-ohhysoosyhyhdddhs-`````````````````.o`-sossoo+``````");
System.Console.WriteLine("``````````````....`````````````````````````````-ohdhyyoosyhddddy///````````````````````:ys:so+``````");
System.Console.WriteLine("```````````````````````````````````````````````-+so+-:o++osdddhh++-`````````````````````ss:+o/``````");
System.Console.WriteLine("````````````````````````````````````````````````--``````:+sshhdh/..`````````````````````/s//s.``````");
System.Console.WriteLine("`````````````````````````````````````````````````````````/++sydhyo-`````````````````````/y--o```````");
System.Console.WriteLine("`````````````````````````````````````````````````````````./++shhs::.````````````````````so`/-```````");
System.Console.WriteLine("``````````````````````````````````````````````````````````:++ohhyo-````````````````````-y.`o````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````-++shhy:/````````````````````+-`-:````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````.++shho+````````````````````.-``-`````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````.++yhy-:``````````````````````````````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````-+shhs:```````````````````````````````````");
System.Console.WriteLine("`````````````````````````````````````````````````````````-+odhy/.```````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````:+odh++`````````````````````````````````````");
System.Console.WriteLine("```````````````````````````````.:o:..-.``````````````.-+shdsy.``````````````````````````````````````");
System.Console.WriteLine("`````````````````````````````.:oyyyysyyooo/+/-...`.-/oshhs/..```````````````````````````````````````");
System.Console.WriteLine("```````````````````````````./osyyyhhhyhhyhyyssysoosyhhs/:```````````````````````````````````````````");
System.Console.WriteLine("``````````````````````````:syyhhhhdo-:/osssssoyysos:--``````````````````````````````````````````````");
System.Console.WriteLine("`````````````````````````/yhhhyyyyys:-````.``-..````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````:so+::.`````..``````````````````````````````````````````````````````````````");
System.Console.WriteLine("```````````````````````-o.``````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("```````````````````````.````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````"); 
SparringMatch(me,Marcus); 
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();





System.Console.WriteLine("You notice there is only a single hallway leading left.");
System.Console.WriteLine("You take that path..");
me.MoveWest();
System.Console.WriteLine("                                             ..--://+++.                                            ");
System.Console.WriteLine("                                             .-:/++osyy`                                            ");
System.Console.WriteLine("                                             ..-/+ossyo                                             ");
System.Console.WriteLine("                                           ``.-:+osyyyo```                                          ");
System.Console.WriteLine("                                          .``..+syhdddy:..                                          ");
System.Console.WriteLine("                                          .`...+osyhhhs:.-                                          ");
System.Console.WriteLine("                                          ....-+ooyyyy+/.-                                          ");
System.Console.WriteLine("                                           ..-/ssyyhhy/:.`                                          ");
System.Console.WriteLine("                                           `..-::/:/ooooo/                                          ");
System.Console.WriteLine("                                         `-:-::+o:+shyss+                                           ");
System.Console.WriteLine("                                        `:///////ooosy+/-                                           ");
System.Console.WriteLine("                                          `-+oo/o+:+hhyys++                                         ");
System.Console.WriteLine("                                         ``.-::://:oo.-+o:                                          ");
System.Console.WriteLine("                                           ``.---:o:`:+o`                                           ");
System.Console.WriteLine("                                               ` -++`+++                                            ");
System.Console.WriteLine("                                                `` .+o`oo/                                          ");
System.Console.WriteLine("                                                ````/o`oo/                                          ");
System.Console.WriteLine("                                                ````:o-+o+                                          ");
System.Console.WriteLine("                                                ````:o:/oo                                          ");
System.Console.WriteLine("                                                ````.-`-+o`                                         ");
System.Console.WriteLine("                                           `    ````````:o-                                         ");
System.Console.WriteLine("                                           `   `````````-++                                         ");
System.Console.WriteLine("                                          .`   ``````..../-                                         ");
System.Console.WriteLine("                                         ``.`....````......`                                        ");
System.Console.WriteLine("                                       `.....`````````..``..``                                      ");
System.Console.WriteLine("                                     ``....``.```.....``````..``                                    ");
System.Console.WriteLine("                                  ``..--::::://::::::::::---.....`                                  ");
System.Console.WriteLine("                                 :++///////////::::::///////:://++/`                                ");
System.Console.WriteLine("                                :syo/:/ooooooo+++/////++ooooosssyys+`                               ");
System.Console.WriteLine("                               -oy+-.-:+++ssyysoo+++++ossyysssyyysso:                               ");
System.Console.WriteLine("                               +oo-.-:/:-:/oyysoooooooosssyysssyyyys+`                              ");
System.Console.WriteLine("                              `+s/..-/:---/syyyyyyyyyyyyyyyyyssssysso-                              ");
System.Console.WriteLine("                              .+s+::/+:--:+hhhhhhhhhhhhhhhhyyyyssssso-                              ");
System.Console.WriteLine("                              .+oo++oo+//+yhddddddddhdddddddyysssssso-                              ");
System.Console.WriteLine("                              .+ooosssyyyyhdmmdddmddmmdmdmdddhyssssoo-                              ");
System.Console.WriteLine("                              `+osssshdddddmmmmmdmmmmmmmmddmdddhsssso-                              ");
System.Console.WriteLine("                              `/oosyhmmmmmmmmmmmmmmmmmmmmmmmmmmdyysso.                              ");
System.Console.WriteLine("                               -+ssydddmmmmmmmmmmmmmmmmmmmmmmmmdhyys+`                              ");
System.Console.WriteLine("                               `/osyddddddmmmmmmmmmmmmmmmmmmmmdddhyo-                               ");
System.Console.WriteLine("                               `./osyddddmmmmmmmmmmmmmmmmmmmmmddhys:``                              ");
System.Console.WriteLine("                               ``./+oyhdddmmmmmmmmmmmmmmmmmmddhhys/-.``                             ");
System.Console.WriteLine("                               ``.-:/osyyhhhddddddddddddddddhdhys+:-.``                             ");
System.Console.WriteLine("                                ``..--:/+osyyhhhdddddddddhhyso+/:--.``                              ");
System.Console.WriteLine("                                  ````.....----:::::::::::----....```                               ");
System.Console.WriteLine("                                     `````````````````````````````                                  ");
 System.Console.WriteLine("In this room you discovered a armor potion! Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No");
 int pickup9 = Convert.ToInt32(Console.ReadLine());
 if(pickup9 == 1)
    {
       inventory.Add(P2);
       System.Console.WriteLine("You added a armor potion to your inventory");
    }
  if(pickup9 == 2)
  {
     System.Console.WriteLine("You left the potion to itself and continue your journey");

     }
     System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem10 = System.Console.ReadLine().ToLower();
    
    if(UseItem10 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
     if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }
       }
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();



        System.Console.WriteLine("You notice there is only a single hallway leading up.");
        System.Console.WriteLine("You take that path..");
        me.MoveNorth();
    }


  }
  if(HallWayChoice4 == "left")
  {
    System.Console.WriteLine("You go left.");
    me.MoveWest();
System.Console.WriteLine("In this room you encounter a hydra, you have no choice but to fight for your life!");    
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````.---------.`````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````---:/+yssyy+.```````````````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````````````````:/:/dhhhhhso:`````````````````");
System.Console.WriteLine("````````````````....---.```````````````````````````````````````````````syydhddhhhhys.```````````````");
System.Console.WriteLine("```````````````://+syys+:.````````````````````````````````````````````:hhhhhhhdddddhy.``````````````");
System.Console.WriteLine("```````````````.```-ssysss/.`````````````````````````````````````````/hhddhhhhhddhhdhs.`````````````");
System.Console.WriteLine("````````````````````ossyssso-``````-``.`.:.````````````````````````-yhhddhhhhhhyhhhhhho.````````````");
System.Console.WriteLine("````````````````````-yyyyyooo+/:::+o.-oo+-`.://:.```````````````-:/hmhddhhhhyyyyyyhhhyho````````````");
System.Console.WriteLine("````````````````````-ossyyyyyyyyyhshyshh++oo/::///:.````````````-ysshddhhhyyhysyhyyyyyyy+```````````");
System.Console.WriteLine("```````````````````.../+ssssyyyshyhddhdhhhhysyh+-.--::-.```````-yhyyhhyyyyysyyyssyysyyyys/``````````");
System.Console.WriteLine("``````````````````````/:-sooyyysdhhhhdhhhhhhhyysosys+::-.`````-yyyhhyyyyssyyssyyssssoyyyso-`````````");
System.Console.WriteLine("`````````````````````:o+.osy/yyhysydddhhyyhyyyyyyyysooso+/-`./hyyyhyssysssosssosysosssyyyso-````````");
System.Console.WriteLine("`````````````````````oh+shhdhhhyyhhhyhhyyyyyssshyyysyhyy/--/yhhhhhhso+oossooosoossoosssyyyos````````");
System.Console.WriteLine("```````````````````-+hdhhddhhddddhyyyyyyyyssyyyysshhhdddhhhhhdhhhhhyo++ooooo+sso+osooooosyys/```````");
System.Console.WriteLine("`````````````````//yhhhhhhdyddhhhhyyhhhyyysyhyssooyyyhhhddddddhhysyys+/++sso+/oo++ooo+oooyysy-``````");
System.Console.WriteLine("``````````````:+sddhdhhshhhhhdddy++oyhhhhyyyhhysssyhyhhhddddhhhyyyosso///+oo+//+o+/+o++oosyyss``````");
System.Console.WriteLine("`````````````/hddhhhhhhyyysyyhhhsssosysyhhhhhhhhyyyhhhhhddddhhyyyysoooo/::++++//oo+/+o+++oosys.`````");
System.Console.WriteLine("```````````./hhhhhsyhhhyyysyyyyso++::/:/yyyyyyyhhhyhhhhhhdddhhhyyyso+ooo+//+++/:/++++oo+/+ooso-`````");
System.Console.WriteLine("```````./+shhyyhhhyhyssyhhhyyyys+/:-syyooyyyyyyhhhhhhdhhhhdddhhyhooo++oo+++++++/:/+o++o+/+oooo.`````");
System.Console.WriteLine("```````-yhhhyyhyysyyhddhysosooso+//syhyyyyyysshyyyyhhddhyssyyhdhhyso+++oo+++oo++//+oo+o++++oo+``````");
System.Console.WriteLine("````````yyyysysooshyhhoosss+:-````.`+//`so:.`.yyyshshhyyhsossyddhho:.``.+-./ssooo+++o++o+++oo:``````");
System.Console.WriteLine("````````..-::...-oosy//+o/.```````````.`/````-yhyhhohhyyhsssyhhdhy:``````:``.o+.:o++oo+o+++oo-``````");
System.Console.WriteLine("````````````.`./yoyo:::-`````````````````````-h:yssooosyssyhhdddhys-``````````+.`.+osso++++oo/``````");
System.Console.WriteLine("````````````./+yys+-.```````````````````````.-.+yyhs+oosysyhhhhyy+/:```````````````oo-soosooo+``````");
System.Console.WriteLine("`````````````+sso+.````````````````````````````-ohhysoosyhyhdddhs-`````````````````.o`-sossoo+``````");
System.Console.WriteLine("``````````````....`````````````````````````````-ohdhyyoosyhddddy///````````````````````:ys:so+``````");
System.Console.WriteLine("```````````````````````````````````````````````-+so+-:o++osdddhh++-`````````````````````ss:+o/``````");
System.Console.WriteLine("````````````````````````````````````````````````--``````:+sshhdh/..`````````````````````/s//s.``````");
System.Console.WriteLine("`````````````````````````````````````````````````````````/++sydhyo-`````````````````````/y--o```````");
System.Console.WriteLine("`````````````````````````````````````````````````````````./++shhs::.````````````````````so`/-```````");
System.Console.WriteLine("``````````````````````````````````````````````````````````:++ohhyo-````````````````````-y.`o````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````-++shhy:/````````````````````+-`-:````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````.++shho+````````````````````.-``-`````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````.++yhy-:``````````````````````````````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````-+shhs:```````````````````````````````````");
System.Console.WriteLine("`````````````````````````````````````````````````````````-+odhy/.```````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````:+odh++`````````````````````````````````````");
System.Console.WriteLine("```````````````````````````````.:o:..-.``````````````.-+shdsy.``````````````````````````````````````");
System.Console.WriteLine("`````````````````````````````.:oyyyysyyooo/+/-...`.-/oshhs/..```````````````````````````````````````");
System.Console.WriteLine("```````````````````````````./osyyyhhhyhhyhyyssysoosyhhs/:```````````````````````````````````````````");
System.Console.WriteLine("``````````````````````````:syyhhhhdo-:/osssssoyysos:--``````````````````````````````````````````````");
System.Console.WriteLine("`````````````````````````/yhhhyyyyys:-````.``-..````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````:so+::.`````..``````````````````````````````````````````````````````````````");
System.Console.WriteLine("```````````````````````-o.``````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("```````````````````````.````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
SparringMatch(me,Squirtle); 
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();





System.Console.WriteLine("You notice there is only a single hallway leading up.");
System.Console.WriteLine("You take that path..");
me.MoveNorth();
System.Console.WriteLine("              .ss/.                                                                                 ");
System.Console.WriteLine("            `ohhhhhs/.                                                                              ");
System.Console.WriteLine("           :hddddhhhhho.                                                                            ");
System.Console.WriteLine("          +hdddddddhhy/.                                                                            ");
System.Console.WriteLine("        .yddhhhhhhhhsooo/.                                                                          ");
System.Console.WriteLine("       /ddddhhhhhhhsoossso/`                                                                        ");
System.Console.WriteLine("     .sdddddhhhyyysoooooooo+:`                                                                      ");
System.Console.WriteLine("   `odddddddhhyy+.`-+ooooooo++:`                                                                    ");
System.Console.WriteLine(" .oddddddddhhhy+`    `:+oooo++++:.                                                                  ");
System.Console.WriteLine("-hdddddhhhddhh+         .:+oooo+++/:.                                                               ");
System.Console.WriteLine(" ./yhddhhhhhhs`            .:+oooo+++/:.                                                            ");
System.Console.WriteLine("    ./oyhhhhy.                .:+oooooo+/:.                                                         ");
System.Console.WriteLine("       `.-/+/                    .:+ooooooo+:.`                                                     ");
System.Console.WriteLine("                                    `-/+oooooo+/-`                                                  ");
System.Console.WriteLine("                                       `.:+oooooo+/-.                                               ");
System.Console.WriteLine("                                           `-/oooooo++:.`                                           ");
System.Console.WriteLine("                                              `.:+oooooo+/-`                                        ");
System.Console.WriteLine("                                                  .:+ooooooo+:.`                                    ");
System.Console.WriteLine("                                                    `-/+oooooo+/-`                                  ");
System.Console.WriteLine("                                                        .:+ooossoo+:.                               ");
System.Console.WriteLine("                                                          `-/oossssso/.`                            ");
System.Console.WriteLine("                                                             `.:+ossssso/-`                         ");
System.Console.WriteLine("                                                                 `:+ossssoo/-`                      ");
System.Console.WriteLine("                                                                    `-/oosssoo/-`                   ");
System.Console.WriteLine("                                                                        `./osssoo+/.`               ");
System.Console.WriteLine("                                                                            `./ossooo+:.            ");
System.Console.WriteLine("                                                                               `-/osssoo+:`         ");
System.Console.WriteLine("                                                                                  `-+ssssoo+-`      ");
System.Console.WriteLine("                                                                                     .:ossssoo/.    ");
System.Console.WriteLine("                                                                                       `:ssssssso:` ");
System.Console.WriteLine("                                                                                         .osss+ysss:");
System.Console.WriteLine("                                                                                         `+yyyysso` ");
System.Console.WriteLine("                                                                                            -+oo:.  ");
 System.Console.WriteLine("In this room you discovered a Axe! Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No]");
 int pickup10 = Convert.ToInt32(Console.ReadLine());
 if(pickup10 == 1)
    {
       inventory.Add(P3);
       System.Console.WriteLine("You added an axe to your inventory");
    }
  if(pickup10 == 2)
    {
      System.Console.WriteLine("You left the axe to itself and continue your journey");

      }
 System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem11 = System.Console.ReadLine().ToLower();
    
    if(UseItem11 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
     if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }
       }     
 System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();


    string HallWayChoice6 = System.Console.ReadLine().ToLower();
System.Console.WriteLine("You see a hallway going up, and another going right");
System.Console.WriteLine("[Enter right to go right] or [Enter up to go up]");
    if(HallWayChoice6 == "up")
    {
      System.Console.WriteLine("You go up.");
      me.MoveNorth();
      System.Console.WriteLine("You notice there is only a single hallway leading to the right.");
      System.Console.WriteLine("You take that path..");
      me.MoveEast();
System.Console.WriteLine("                                             ..--://+++.                                            ");
System.Console.WriteLine("                                             .-:/++osyy`                                            ");
System.Console.WriteLine("                                             ..-/+ossyo                                             ");
System.Console.WriteLine("                                           ``.-:+osyyyo```                                          ");
System.Console.WriteLine("                                          .``..+syhdddy:..                                          ");
System.Console.WriteLine("                                          .`...+osyhhhs:.-                                          ");
System.Console.WriteLine("                                          ....-+ooyyyy+/.-                                          ");
System.Console.WriteLine("                                           ..-/ssyyhhy/:.`                                          ");
System.Console.WriteLine("                                           `..-::/:/ooooo/                                          ");
System.Console.WriteLine("                                         `-:-::+o:+shyss+                                           ");
System.Console.WriteLine("                                        `:///////ooosy+/-                                           ");
System.Console.WriteLine("                                          `-+oo/o+:+hhyys++                                         ");
System.Console.WriteLine("                                         ``.-::://:oo.-+o:                                          ");
System.Console.WriteLine("                                           ``.---:o:`:+o`                                           ");
System.Console.WriteLine("                                               ` -++`+++                                            ");
System.Console.WriteLine("                                                `` .+o`oo/                                          ");
System.Console.WriteLine("                                                ````/o`oo/                                          ");
System.Console.WriteLine("                                                ````:o-+o+                                          ");
System.Console.WriteLine("                                                ````:o:/oo                                          ");
System.Console.WriteLine("                                                ````.-`-+o`                                         ");
System.Console.WriteLine("                                           `    ````````:o-                                         ");
System.Console.WriteLine("                                           `   `````````-++                                         ");
System.Console.WriteLine("                                          .`   ``````..../-                                         ");
System.Console.WriteLine("                                         ``.`....````......`                                        ");
System.Console.WriteLine("                                       `.....`````````..``..``                                      ");
System.Console.WriteLine("                                     ``....``.```.....``````..``                                    ");
System.Console.WriteLine("                                  ``..--::::://::::::::::---.....`                                  ");
System.Console.WriteLine("                                 :++///////////::::::///////:://++/`                                ");
System.Console.WriteLine("                                :syo/:/ooooooo+++/////++ooooosssyys+`                               ");
System.Console.WriteLine("                               -oy+-.-:+++ssyysoo+++++ossyysssyyysso:                               ");
System.Console.WriteLine("                               +oo-.-:/:-:/oyysoooooooosssyysssyyyys+`                              ");
System.Console.WriteLine("                              `+s/..-/:---/syyyyyyyyyyyyyyyyyssssysso-                              ");
System.Console.WriteLine("                              .+s+::/+:--:+hhhhhhhhhhhhhhhhyyyyssssso-                              ");
System.Console.WriteLine("                              .+oo++oo+//+yhddddddddhdddddddyysssssso-                              ");
System.Console.WriteLine("                              .+ooosssyyyyhdmmdddmddmmdmdmdddhyssssoo-                              ");
System.Console.WriteLine("                              `+osssshdddddmmmmmdmmmmmmmmddmdddhsssso-                              ");
System.Console.WriteLine("                              `/oosyhmmmmmmmmmmmmmmmmmmmmmmmmmmdyysso.                              ");
System.Console.WriteLine("                               -+ssydddmmmmmmmmmmmmmmmmmmmmmmmmdhyys+`                              ");
System.Console.WriteLine("                               `/osyddddddmmmmmmmmmmmmmmmmmmmmdddhyo-                               ");
System.Console.WriteLine("                               `./osyddddmmmmmmmmmmmmmmmmmmmmmddhys:``                              ");
System.Console.WriteLine("                               ``./+oyhdddmmmmmmmmmmmmmmmmmmddhhys/-.``                             ");
System.Console.WriteLine("                               ``.-:/osyyhhhddddddddddddddddhdhys+:-.``                             ");
System.Console.WriteLine("                                ``..--:/+osyyhhhdddddddddhhyso+/:--.``                              ");
System.Console.WriteLine("                                  ````.....----:::::::::::----....```                               ");
System.Console.WriteLine("                                     `````````````````````````````                                  ");
 System.Console.WriteLine("In this room you discovered a armor potion! Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No]");
 int pickup11 = Convert.ToInt32(Console.ReadLine());
 if(pickup11 == 1)
    {
       inventory.Add(P2);
       System.Console.WriteLine("You added a armor potion to your inventory");
    }
  if(pickup11 == 2)
  {
     System.Console.WriteLine("You left the potion to itself and continue your journey");

     }
System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem12 = System.Console.ReadLine().ToLower();
    
    if(UseItem12 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
     if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }
       }     
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();


      System.Console.WriteLine("You notice there is only a single hallway leading up.");
      System.Console.WriteLine("You take that path..");
      me.MoveNorth();
    }

    if(HallWayChoice6 == "right")
    {
      System.Console.WriteLine("You go right.");
      me.MoveEast();
System.Console.WriteLine("In this room you encounter a drake. you have no choice but to fight for your life!");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````.---------.`````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````---:/+yssyy+.```````````````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````````````````:/:/dhhhhhso:`````````````````");
System.Console.WriteLine("````````````````....---.```````````````````````````````````````````````syydhddhhhhys.```````````````");
System.Console.WriteLine("```````````````://+syys+:.````````````````````````````````````````````:hhhhhhhdddddhy.``````````````");
System.Console.WriteLine("```````````````.```-ssysss/.`````````````````````````````````````````/hhddhhhhhddhhdhs.`````````````");
System.Console.WriteLine("````````````````````ossyssso-``````-``.`.:.````````````````````````-yhhddhhhhhhyhhhhhho.````````````");
System.Console.WriteLine("````````````````````-yyyyyooo+/:::+o.-oo+-`.://:.```````````````-:/hmhddhhhhyyyyyyhhhyho````````````");
System.Console.WriteLine("````````````````````-ossyyyyyyyyyhshyshh++oo/::///:.````````````-ysshddhhhyyhysyhyyyyyyy+```````````");
System.Console.WriteLine("```````````````````.../+ssssyyyshyhddhdhhhhysyh+-.--::-.```````-yhyyhhyyyyysyyyssyysyyyys/``````````");
System.Console.WriteLine("``````````````````````/:-sooyyysdhhhhdhhhhhhhyysosys+::-.`````-yyyhhyyyyssyyssyyssssoyyyso-`````````");
System.Console.WriteLine("`````````````````````:o+.osy/yyhysydddhhyyhyyyyyyyysooso+/-`./hyyyhyssysssosssosysosssyyyso-````````");
System.Console.WriteLine("`````````````````````oh+shhdhhhyyhhhyhhyyyyyssshyyysyhyy/--/yhhhhhhso+oossooosoossoosssyyyos````````");
System.Console.WriteLine("```````````````````-+hdhhddhhddddhyyyyyyyyssyyyysshhhdddhhhhhdhhhhhyo++ooooo+sso+osooooosyys/```````");
System.Console.WriteLine("`````````````````//yhhhhhhdyddhhhhyyhhhyyysyhyssooyyyhhhddddddhhysyys+/++sso+/oo++ooo+oooyysy-``````");
System.Console.WriteLine("``````````````:+sddhdhhshhhhhdddy++oyhhhhyyyhhysssyhyhhhddddhhhyyyosso///+oo+//+o+/+o++oosyyss``````");
System.Console.WriteLine("`````````````/hddhhhhhhyyysyyhhhsssosysyhhhhhhhhyyyhhhhhddddhhyyyysoooo/::++++//oo+/+o+++oosys.`````");
System.Console.WriteLine("```````````./hhhhhsyhhhyyysyyyyso++::/:/yyyyyyyhhhyhhhhhhdddhhhyyyso+ooo+//+++/:/++++oo+/+ooso-`````");
System.Console.WriteLine("```````./+shhyyhhhyhyssyhhhyyyys+/:-syyooyyyyyyhhhhhhdhhhhdddhhyhooo++oo+++++++/:/+o++o+/+oooo.`````");
System.Console.WriteLine("```````-yhhhyyhyysyyhddhysosooso+//syhyyyyyysshyyyyhhddhyssyyhdhhyso+++oo+++oo++//+oo+o++++oo+``````");
System.Console.WriteLine("````````yyyysysooshyhhoosss+:-````.`+//`so:.`.yyyshshhyyhsossyddhho:.``.+-./ssooo+++o++o+++oo:``````");
System.Console.WriteLine("````````..-::...-oosy//+o/.```````````.`/````-yhyhhohhyyhsssyhhdhy:``````:``.o+.:o++oo+o+++oo-``````");
System.Console.WriteLine("````````````.`./yoyo:::-`````````````````````-h:yssooosyssyhhdddhys-``````````+.`.+osso++++oo/``````");
System.Console.WriteLine("````````````./+yys+-.```````````````````````.-.+yyhs+oosysyhhhhyy+/:```````````````oo-soosooo+``````");
System.Console.WriteLine("`````````````+sso+.````````````````````````````-ohhysoosyhyhdddhs-`````````````````.o`-sossoo+``````");
System.Console.WriteLine("``````````````....`````````````````````````````-ohdhyyoosyhddddy///````````````````````:ys:so+``````");
System.Console.WriteLine("```````````````````````````````````````````````-+so+-:o++osdddhh++-`````````````````````ss:+o/``````");
System.Console.WriteLine("````````````````````````````````````````````````--``````:+sshhdh/..`````````````````````/s//s.``````");
System.Console.WriteLine("`````````````````````````````````````````````````````````/++sydhyo-`````````````````````/y--o```````");
System.Console.WriteLine("`````````````````````````````````````````````````````````./++shhs::.````````````````````so`/-```````");
System.Console.WriteLine("``````````````````````````````````````````````````````````:++ohhyo-````````````````````-y.`o````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````-++shhy:/````````````````````+-`-:````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````.++shho+````````````````````.-``-`````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````.++yhy-:``````````````````````````````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````-+shhs:```````````````````````````````````");
System.Console.WriteLine("`````````````````````````````````````````````````````````-+odhy/.```````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````:+odh++`````````````````````````````````````");
System.Console.WriteLine("```````````````````````````````.:o:..-.``````````````.-+shdsy.``````````````````````````````````````");
System.Console.WriteLine("`````````````````````````````.:oyyyysyyooo/+/-...`.-/oshhs/..```````````````````````````````````````");
System.Console.WriteLine("```````````````````````````./osyyyhhhyhhyhyyssysoosyhhs/:```````````````````````````````````````````");
System.Console.WriteLine("``````````````````````````:syyhhhhdo-:/osssssoyysos:--``````````````````````````````````````````````");
System.Console.WriteLine("`````````````````````````/yhhhyyyyys:-````.``-..````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````:so+::.`````..``````````````````````````````````````````````````````````````");
System.Console.WriteLine("```````````````````````-o.``````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("```````````````````````.````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
SparringMatch(me,Toothless); 
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();





      System.Console.WriteLine("You notice there are 2 hallways, one going right, and the other up.");
      System.Console.WriteLine("what path do you choose?..");      
      System.Console.WriteLine("[Enter right to go right] or [Enter up to go up]");
      string HallWayChoice7 = System.Console.ReadLine().ToLower();
        if(HallWayChoice7 == "up")
        {
          System.Console.WriteLine("You go up.");
          me.MoveNorth();
System.Console.WriteLine("                                             ..--://+++.                                            ");
System.Console.WriteLine("                                             .-:/++osyy`                                            ");
System.Console.WriteLine("                                             ..-/+ossyo                                             ");
System.Console.WriteLine("                                           ``.-:+osyyyo```                                          ");
System.Console.WriteLine("                                          .``..+syhdddy:..                                          ");
System.Console.WriteLine("                                          .`...+osyhhhs:.-                                          ");
System.Console.WriteLine("                                          ....-+ooyyyy+/.-                                          ");
System.Console.WriteLine("                                           ..-/ssyyhhy/:.`                                          ");
System.Console.WriteLine("                                           `..-::/:/ooooo/                                          ");
System.Console.WriteLine("                                         `-:-::+o:+shyss+                                           ");
System.Console.WriteLine("                                        `:///////ooosy+/-                                           ");
System.Console.WriteLine("                                          `-+oo/o+:+hhyys++                                         ");
System.Console.WriteLine("                                         ``.-::://:oo.-+o:                                          ");
System.Console.WriteLine("                                           ``.---:o:`:+o`                                           ");
System.Console.WriteLine("                                               ` -++`+++                                            ");
System.Console.WriteLine("                                                `` .+o`oo/                                          ");
System.Console.WriteLine("                                                ````/o`oo/                                          ");
System.Console.WriteLine("                                                ````:o-+o+                                          ");
System.Console.WriteLine("                                                ````:o:/oo                                          ");
System.Console.WriteLine("                                                ````.-`-+o`                                         ");
System.Console.WriteLine("                                           `    ````````:o-                                         ");
System.Console.WriteLine("                                           `   `````````-++                                         ");
System.Console.WriteLine("                                          .`   ``````..../-                                         ");
System.Console.WriteLine("                                         ``.`....````......`                                        ");
System.Console.WriteLine("                                       `.....`````````..``..``                                      ");
System.Console.WriteLine("                                     ``....``.```.....``````..``                                    ");
System.Console.WriteLine("                                  ``..--::::://::::::::::---.....`                                  ");
System.Console.WriteLine("                                 :++///////////::::::///////:://++/`                                ");
System.Console.WriteLine("                                :syo/:/ooooooo+++/////++ooooosssyys+`                               ");
System.Console.WriteLine("                               -oy+-.-:+++ssyysoo+++++ossyysssyyysso:                               ");
System.Console.WriteLine("                               +oo-.-:/:-:/oyysoooooooosssyysssyyyys+`                              ");
System.Console.WriteLine("                              `+s/..-/:---/syyyyyyyyyyyyyyyyyssssysso-                              ");
System.Console.WriteLine("                              .+s+::/+:--:+hhhhhhhhhhhhhhhhyyyyssssso-                              ");
System.Console.WriteLine("                              .+oo++oo+//+yhddddddddhdddddddyysssssso-                              ");
System.Console.WriteLine("                              .+ooosssyyyyhdmmdddmddmmdmdmdddhyssssoo-                              ");
System.Console.WriteLine("                              `+osssshdddddmmmmmdmmmmmmmmddmdddhsssso-                              ");
System.Console.WriteLine("                              `/oosyhmmmmmmmmmmmmmmmmmmmmmmmmmmdyysso.                              ");
System.Console.WriteLine("                               -+ssydddmmmmmmmmmmmmmmmmmmmmmmmmdhyys+`                              ");
System.Console.WriteLine("                               `/osyddddddmmmmmmmmmmmmmmmmmmmmdddhyo-                               ");
System.Console.WriteLine("                               `./osyddddmmmmmmmmmmmmmmmmmmmmmddhys:``                              ");
System.Console.WriteLine("                               ``./+oyhdddmmmmmmmmmmmmmmmmmmddhhys/-.``                             ");
System.Console.WriteLine("                               ``.-:/osyyhhhddddddddddddddddhdhys+:-.``                             ");
System.Console.WriteLine("                                ``..--:/+osyyhhhdddddddddhhyso+/:--.``                              ");
System.Console.WriteLine("                                  ````.....----:::::::::::----....```                               ");
System.Console.WriteLine("                                     `````````````````````````````                                  ");
 System.Console.WriteLine("In this room you discovered a armor potion! Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No]");
 int pickup12 = Convert.ToInt32(Console.ReadLine());
 if(pickup12 == 1)
    {
       inventory.Add(P2);
       System.Console.WriteLine("You added a armor potion to your inventory");
    }
  if(pickup12 == 2)
  {
     System.Console.WriteLine("You left the potion to itself and continue your journey");

     }
System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem13 = System.Console.ReadLine().ToLower();
    
    if(UseItem13 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
     if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }
       }     
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();


          System.Console.WriteLine("You notice there is only a single hallway leading up.");
          System.Console.WriteLine("You take that path..");
          me.MoveNorth();
        }
        if(HallWayChoice7 == "right")
        {
          System.Console.WriteLine("You go right.");
          me.MoveEast();
System.Console.WriteLine("                                             ..--://+++.                                            ");
System.Console.WriteLine("                                             .-:/++osyy`                                            ");
System.Console.WriteLine("                                             ..-/+ossyo                                             ");
System.Console.WriteLine("                                           ``.-:+osyyyo```                                          ");
System.Console.WriteLine("                                          .``..+syhdddy:..                                          ");
System.Console.WriteLine("                                          .`...+osyhhhs:.-                                          ");
System.Console.WriteLine("                                          ....-+ooyyyy+/.-                                          ");
System.Console.WriteLine("                                           ..-/ssyyhhy/:.`                                          ");
System.Console.WriteLine("                                           `..-::/:/ooooo/                                          ");
System.Console.WriteLine("                                         `-:-::+o:+shyss+                                           ");
System.Console.WriteLine("                                        `:///////ooosy+/-                                           ");
System.Console.WriteLine("                                          `-+oo/o+:+hhyys++                                         ");
System.Console.WriteLine("                                         ``.-::://:oo.-+o:                                          ");
System.Console.WriteLine("                                           ``.---:o:`:+o`                                           ");
System.Console.WriteLine("                                               ` -++`+++                                            ");
System.Console.WriteLine("                                                `` .+o`oo/                                          ");
System.Console.WriteLine("                                                ````/o`oo/                                          ");
System.Console.WriteLine("                                                ````:o-+o+                                          ");
System.Console.WriteLine("                                                ````:o:/oo                                          ");
System.Console.WriteLine("                                                ````.-`-+o`                                         ");
System.Console.WriteLine("                                           `    ````````:o-                                         ");
System.Console.WriteLine("                                           `   `````````-++                                         ");
System.Console.WriteLine("                                          .`   ``````..../-                                         ");
System.Console.WriteLine("                                         ``.`....````......`                                        ");
System.Console.WriteLine("                                       `.....`````````..``..``                                      ");
System.Console.WriteLine("                                     ``....``.```.....``````..``                                    ");
System.Console.WriteLine("                                  ``..--::::://::::::::::---.....`                                  ");
System.Console.WriteLine("                                 :++///////////::::::///////:://++/`                                ");
System.Console.WriteLine("                                :syo/:/ooooooo+++/////++ooooosssyys+`                               ");
System.Console.WriteLine("                               -oy+-.-:+++ssyysoo+++++ossyysssyyysso:                               ");
System.Console.WriteLine("                               +oo-.-:/:-:/oyysoooooooosssyysssyyyys+`                              ");
System.Console.WriteLine("                              `+s/..-/:---/syyyyyyyyyyyyyyyyyssssysso-                              ");
System.Console.WriteLine("                              .+s+::/+:--:+hhhhhhhhhhhhhhhhyyyyssssso-                              ");
System.Console.WriteLine("                              .+oo++oo+//+yhddddddddhdddddddyysssssso-                              ");
System.Console.WriteLine("                              .+ooosssyyyyhdmmdddmddmmdmdmdddhyssssoo-                              ");
System.Console.WriteLine("                              `+osssshdddddmmmmmdmmmmmmmmddmdddhsssso-                              ");
System.Console.WriteLine("                              `/oosyhmmmmmmmmmmmmmmmmmmmmmmmmmmdyysso.                              ");
System.Console.WriteLine("                               -+ssydddmmmmmmmmmmmmmmmmmmmmmmmmdhyys+`                              ");
System.Console.WriteLine("                               `/osyddddddmmmmmmmmmmmmmmmmmmmmdddhyo-                               ");
System.Console.WriteLine("                               `./osyddddmmmmmmmmmmmmmmmmmmmmmddhys:``                              ");
System.Console.WriteLine("                               ``./+oyhdddmmmmmmmmmmmmmmmmmmddhhys/-.``                             ");
System.Console.WriteLine("                               ``.-:/osyyhhhddddddddddddddddhdhys+:-.``                             ");
System.Console.WriteLine("                                ``..--:/+osyyhhhdddddddddhhyso+/:--.``                              ");
System.Console.WriteLine("                                  ````.....----:::::::::::----....```                               ");
System.Console.WriteLine("                                     `````````````````````````````                                  ");

 System.Console.WriteLine("In this room you discovered a potion of healing! Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No]");
 int pickup13 = Convert.ToInt32(Console.ReadLine());
 if(pickup13 == 1)
    {
       inventory.Add(P1);
       System.Console.WriteLine("You added a healing potion to your inventory");
    }
  if(pickup13 ==2)
    {
      System.Console.WriteLine("You left the potion to itself and continue your journey");

      }
 System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem14 = System.Console.ReadLine().ToLower();
    
    if(UseItem14 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
     if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }
       }     
 System.Console.WriteLine("Press any key to continue..."); 
 Console.ReadKey(); 
 System.Console.Clear();

          System.Console.WriteLine("You notice there is only a single hallway leading up.");
          System.Console.WriteLine("You take that path..");
          me.MoveNorth();
System.Console.WriteLine("In this room you encounter a leviathan, you have no choice but to fight for your life!");          
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````.---------.`````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````---:/+yssyy+.```````````````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````````````````:/:/dhhhhhso:`````````````````");
System.Console.WriteLine("````````````````....---.```````````````````````````````````````````````syydhddhhhhys.```````````````");
System.Console.WriteLine("```````````````://+syys+:.````````````````````````````````````````````:hhhhhhhdddddhy.``````````````");
System.Console.WriteLine("```````````````.```-ssysss/.`````````````````````````````````````````/hhddhhhhhddhhdhs.`````````````");
System.Console.WriteLine("````````````````````ossyssso-``````-``.`.:.````````````````````````-yhhddhhhhhhyhhhhhho.````````````");
System.Console.WriteLine("````````````````````-yyyyyooo+/:::+o.-oo+-`.://:.```````````````-:/hmhddhhhhyyyyyyhhhyho````````````");
System.Console.WriteLine("````````````````````-ossyyyyyyyyyhshyshh++oo/::///:.````````````-ysshddhhhyyhysyhyyyyyyy+```````````");
System.Console.WriteLine("```````````````````.../+ssssyyyshyhddhdhhhhysyh+-.--::-.```````-yhyyhhyyyyysyyyssyysyyyys/``````````");
System.Console.WriteLine("``````````````````````/:-sooyyysdhhhhdhhhhhhhyysosys+::-.`````-yyyhhyyyyssyyssyyssssoyyyso-`````````");
System.Console.WriteLine("`````````````````````:o+.osy/yyhysydddhhyyhyyyyyyyysooso+/-`./hyyyhyssysssosssosysosssyyyso-````````");
System.Console.WriteLine("`````````````````````oh+shhdhhhyyhhhyhhyyyyyssshyyysyhyy/--/yhhhhhhso+oossooosoossoosssyyyos````````");
System.Console.WriteLine("```````````````````-+hdhhddhhddddhyyyyyyyyssyyyysshhhdddhhhhhdhhhhhyo++ooooo+sso+osooooosyys/```````");
System.Console.WriteLine("`````````````````//yhhhhhhdyddhhhhyyhhhyyysyhyssooyyyhhhddddddhhysyys+/++sso+/oo++ooo+oooyysy-``````");
System.Console.WriteLine("``````````````:+sddhdhhshhhhhdddy++oyhhhhyyyhhysssyhyhhhddddhhhyyyosso///+oo+//+o+/+o++oosyyss``````");
System.Console.WriteLine("`````````````/hddhhhhhhyyysyyhhhsssosysyhhhhhhhhyyyhhhhhddddhhyyyysoooo/::++++//oo+/+o+++oosys.`````");
System.Console.WriteLine("```````````./hhhhhsyhhhyyysyyyyso++::/:/yyyyyyyhhhyhhhhhhdddhhhyyyso+ooo+//+++/:/++++oo+/+ooso-`````");
System.Console.WriteLine("```````./+shhyyhhhyhyssyhhhyyyys+/:-syyooyyyyyyhhhhhhdhhhhdddhhyhooo++oo+++++++/:/+o++o+/+oooo.`````");
System.Console.WriteLine("```````-yhhhyyhyysyyhddhysosooso+//syhyyyyyysshyyyyhhddhyssyyhdhhyso+++oo+++oo++//+oo+o++++oo+``````");
System.Console.WriteLine("````````yyyysysooshyhhoosss+:-````.`+//`so:.`.yyyshshhyyhsossyddhho:.``.+-./ssooo+++o++o+++oo:``````");
System.Console.WriteLine("````````..-::...-oosy//+o/.```````````.`/````-yhyhhohhyyhsssyhhdhy:``````:``.o+.:o++oo+o+++oo-``````");
System.Console.WriteLine("````````````.`./yoyo:::-`````````````````````-h:yssooosyssyhhdddhys-``````````+.`.+osso++++oo/``````");
System.Console.WriteLine("````````````./+yys+-.```````````````````````.-.+yyhs+oosysyhhhhyy+/:```````````````oo-soosooo+``````");
System.Console.WriteLine("`````````````+sso+.````````````````````````````-ohhysoosyhyhdddhs-`````````````````.o`-sossoo+``````");
System.Console.WriteLine("``````````````....`````````````````````````````-ohdhyyoosyhddddy///````````````````````:ys:so+``````");
System.Console.WriteLine("```````````````````````````````````````````````-+so+-:o++osdddhh++-`````````````````````ss:+o/``````");
System.Console.WriteLine("````````````````````````````````````````````````--``````:+sshhdh/..`````````````````````/s//s.``````");
System.Console.WriteLine("`````````````````````````````````````````````````````````/++sydhyo-`````````````````````/y--o```````");
System.Console.WriteLine("`````````````````````````````````````````````````````````./++shhs::.````````````````````so`/-```````");
System.Console.WriteLine("``````````````````````````````````````````````````````````:++ohhyo-````````````````````-y.`o````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````-++shhy:/````````````````````+-`-:````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````.++shho+````````````````````.-``-`````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````.++yhy-:``````````````````````````````````");
System.Console.WriteLine("``````````````````````````````````````````````````````````-+shhs:```````````````````````````````````");
System.Console.WriteLine("`````````````````````````````````````````````````````````-+odhy/.```````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````:+odh++`````````````````````````````````````");
System.Console.WriteLine("```````````````````````````````.:o:..-.``````````````.-+shdsy.``````````````````````````````````````");
System.Console.WriteLine("`````````````````````````````.:oyyyysyyooo/+/-...`.-/oshhs/..```````````````````````````````````````");
System.Console.WriteLine("```````````````````````````./osyyyhhhyhhyhyyssysoosyhhs/:```````````````````````````````````````````");
System.Console.WriteLine("``````````````````````````:syyhhhhdo-:/osssssoyysos:--``````````````````````````````````````````````");
System.Console.WriteLine("`````````````````````````/yhhhyyyyys:-````.``-..````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````:so+::.`````..``````````````````````````````````````````````````````````````");
System.Console.WriteLine("```````````````````````-o.``````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("```````````````````````.````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
System.Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````");
SparringMatch(me,Marcus); 
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();




System.Console.WriteLine("You notice there is only a single hallway leading left.");
System.Console.WriteLine("You take that path..");
me.MoveWest();
System.Console.WriteLine("                                             ..--://+++.                                            ");
System.Console.WriteLine("                                             .-:/++osyy`                                            ");
System.Console.WriteLine("                                             ..-/+ossyo                                             ");
System.Console.WriteLine("                                           ``.-:+osyyyo```                                          ");
System.Console.WriteLine("                                          .``..+syhdddy:..                                          ");
System.Console.WriteLine("                                          .`...+osyhhhs:.-                                          ");
System.Console.WriteLine("                                          ....-+ooyyyy+/.-                                          ");
System.Console.WriteLine("                                           ..-/ssyyhhy/:.`                                          ");
System.Console.WriteLine("                                           `..-::/:/ooooo/                                          ");
System.Console.WriteLine("                                         `-:-::+o:+shyss+                                           ");
System.Console.WriteLine("                                        `:///////ooosy+/-                                           ");
System.Console.WriteLine("                                          `-+oo/o+:+hhyys++                                         ");
System.Console.WriteLine("                                         ``.-::://:oo.-+o:                                          ");
System.Console.WriteLine("                                           ``.---:o:`:+o`                                           ");
System.Console.WriteLine("                                               ` -++`+++                                            ");
System.Console.WriteLine("                                                `` .+o`oo/                                          ");
System.Console.WriteLine("                                                ````/o`oo/                                          ");
System.Console.WriteLine("                                                ````:o-+o+                                          ");
System.Console.WriteLine("                                                ````:o:/oo                                          ");
System.Console.WriteLine("                                                ````.-`-+o`                                         ");
System.Console.WriteLine("                                           `    ````````:o-                                         ");
System.Console.WriteLine("                                           `   `````````-++                                         ");
System.Console.WriteLine("                                          .`   ``````..../-                                         ");
System.Console.WriteLine("                                         ``.`....````......`                                        ");
System.Console.WriteLine("                                       `.....`````````..``..``                                      ");
System.Console.WriteLine("                                     ``....``.```.....``````..``                                    ");
System.Console.WriteLine("                                  ``..--::::://::::::::::---.....`                                  ");
System.Console.WriteLine("                                 :++///////////::::::///////:://++/`                                ");
System.Console.WriteLine("                                :syo/:/ooooooo+++/////++ooooosssyys+`                               ");
System.Console.WriteLine("                               -oy+-.-:+++ssyysoo+++++ossyysssyyysso:                               ");
System.Console.WriteLine("                               +oo-.-:/:-:/oyysoooooooosssyysssyyyys+`                              ");
System.Console.WriteLine("                              `+s/..-/:---/syyyyyyyyyyyyyyyyyssssysso-                              ");
System.Console.WriteLine("                              .+s+::/+:--:+hhhhhhhhhhhhhhhhyyyyssssso-                              ");
System.Console.WriteLine("                              .+oo++oo+//+yhddddddddhdddddddyysssssso-                              ");
System.Console.WriteLine("                              .+ooosssyyyyhdmmdddmddmmdmdmdddhyssssoo-                              ");
System.Console.WriteLine("                              `+osssshdddddmmmmmdmmmmmmmmddmdddhsssso-                              ");
System.Console.WriteLine("                              `/oosyhmmmmmmmmmmmmmmmmmmmmmmmmmmdyysso.                              ");
System.Console.WriteLine("                               -+ssydddmmmmmmmmmmmmmmmmmmmmmmmmdhyys+`                              ");
System.Console.WriteLine("                               `/osyddddddmmmmmmmmmmmmmmmmmmmmdddhyo-                               ");
System.Console.WriteLine("                               `./osyddddmmmmmmmmmmmmmmmmmmmmmddhys:``                              ");
System.Console.WriteLine("                               ``./+oyhdddmmmmmmmmmmmmmmmmmmddhhys/-.``                             ");
System.Console.WriteLine("                               ``.-:/osyyhhhddddddddddddddddhdhys+:-.``                             ");
System.Console.WriteLine("                                ``..--:/+osyyhhhdddddddddhhyso+/:--.``                              ");
System.Console.WriteLine("                                  ````.....----:::::::::::----....```                               ");
System.Console.WriteLine("                                     `````````````````````````````                                  ");
 System.Console.WriteLine("In this room you discovered a armor potion! Do you pick it up?");
 System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No]");
 int pickup14 = Convert.ToInt32(Console.ReadLine());
 if(pickup14 == 1)
    {
       inventory.Add(P2);
       System.Console.WriteLine("You added a armor potion to your inventory");
    }
  if(pickup14 == 2)
  {
     System.Console.WriteLine("You left the potion to itself and continue your journey");

     }
System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem15 = System.Console.ReadLine().ToLower();
    
    if(UseItem15 == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
     if(UseItemSlot > 3){
       
      System.Console.WriteLine("There is nothing here to use!");
      
     }
       }     
System.Console.WriteLine("Press any key to continue..."); 
Console.ReadKey(); 
System.Console.Clear();          
          System.Console.WriteLine("You notice there is only a single hallway leading up.");
          System.Console.WriteLine("You take that path..");
          me.MoveNorth(); 
        }
    }
  }


}


System.Console.WriteLine("////////////////////////////////////////////////////////////");
System.Console.WriteLine("////                    CONGRATS                        ////");
System.Console.WriteLine("////                 YOU'VE ESCAPED                     ////");
System.Console.WriteLine("////                    YOU WIN                         ////");
System.Console.WriteLine("////////////////////////////////////////////////////////////");
 System.Environment.Exit(0);







  }
  //
  // make avaible moves only for left and right depending on elvator, make if statements that will determine who gets what and faces what
  // engage in battles/edit sparringmatch/ 
  // implement final boss 
  // make sure you give option to pick up or ignore/drop items 


    //PlayerCharacter me = new PlayerCharacter(PCname,Sp33d);
   // me.ChangeRace(RacePicked);
   // System.Console.WriteLine(me);



// CREATE L1 and L2 based on left or right choice 
/*
    System.Console.WriteLine("Enter a random number [1-15] ");
    int L1 = Convert.ToInt32(Console.ReadLine());
    while ((L1 < 1) ||(L1 > 15))
    {
      System.Console.WriteLine("Your number was out of bounds! try again");
      L1 = Convert.ToInt32(Console.ReadLine());
    }
    System.Console.WriteLine("Enter another random number [1-15] ");
    int L2 = Convert.ToInt32(Console.ReadLine()); 
    while ((L2 < 1) ||(L2 > 15))
    {
      System.Console.WriteLine("Your number was out of bounds! try again");
      L2 = Convert.ToInt32(Console.ReadLine());
    }
*/

/*
    PlayerCharacter me = new PlayerCharacter(PCname,L1,L2,Sp33d);
    me.ChangeRace(RacePicked);
    System.Console.WriteLine(me);
*/








  //
  // THIS PART CREATES THE INVENTORY < REMEMBER TO ADD DROP/PICKUP >
  //

  /*
    Container<Item> inventory = new Container<Item>(0);
    System.Console.WriteLine("====== adding stuff =====");

    Potion P1 = new HealingPotion();
    P1.recipient = me;
    Potion P2 = new ArmorPotion();
    P2.recipient = me;
    Weapon P3 = new Axe();
    P3.recipient = me;
    inventory.Add(P1);
    inventory.Add(P2);
    inventory.Add(P3);

    
    System.Console.WriteLine("Here is your inventory.");

    System.Console.WriteLine(inventory); 

    System.Console.WriteLine("Do you want to use an item? [Yes or No] ");
    string UseItem = System.Console.ReadLine().ToLower();
    
    if(UseItem == "yes"){
      System.Console.WriteLine(inventory);
      System.Console.WriteLine("What slot do you want to use? ");
      int UseItemSlot = Convert.ToInt32(Console.ReadLine());

    if (UseItemSlot == 3){
      Item itemInHand = inventory.get(3);
      if (inventory.Remove(3) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 2){
      Item itemInHand = inventory.get(2);
      if (inventory.Remove(2) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }
    if (UseItemSlot == 1){
      Item itemInHand = inventory.get(1);
      if (inventory.Remove(1) == true){
        itemInHand.used();
        System.Console.WriteLine(me.Use(itemInHand));
    }
    else {
      System.Console.WriteLine("There is nothing here to use!");
      }
    }

       }
    
    System.Console.WriteLine(me);
*/




// ALL THIS SHIT HAS NO USER INTERACTION JUST HERE TO SHOW IT WORKS 

   


//    System.Console.WriteLine(me);
// System.Console.WriteLine(me.Defend());
//  System.Console.WriteLine(me.Rest());
// System.Console.WriteLine(me.DefendAgainst(Marcus));
//  System.Console.WriteLine(me.Attack(Marcus));
//Leviathan Marcus = new Leviathan();
//SparringMatch(me,Marcus);

// System.Console.WriteLine("In this room you discovered a Axe! Do you pick it up?");
// System.Console.WriteLine("[Enter 1 for Yes] [Enter 2 for No");
// int pickup = Convert.ToInt32(Console.ReadLine());
// if(pickup == 1)
//    {
//       inventory.Add(P3);
//       System.Console.WriteLine("You added an axe to your inventory");
//    }
//  if(pickup == 2)
//    {
//      System.Console.WriteLine("You left the axe to itself and continue your journey");
//
//      }
// System.Console.WriteLine("Press any key to continue..."); 
//Console.ReadKey(); 
//System.Console.Clear();
//
  }    
  
private static void SparringMatch(Creature attacker, Creature defender)
        {
          //  System.Console.Clear();
            System.Console.WriteLine("========================");
            System.Console.WriteLine("Let the fight begin! " + attacker.GetType().Name + " and " +
                                      defender.GetType().Name + "\n\n\n");
            while ((attacker.HP > 0) && (defender.HP > 0))
            {
              System.Console.WriteLine("What would you like to do?");
              System.Console.WriteLine("1) Attack     2)Inspect your enemy ");
              string choice = System.Console.ReadLine();
                if (choice == "1"){
                System.Console.WriteLine(attacker.Attack(defender));
                System.Console.WriteLine(defender.Attack(attacker));
                }
                
                if (choice == "2")
                {
                 System.Console.WriteLine("Here are your opponents stats");
                  System.Console.WriteLine(defender);
                  System.Console.WriteLine(defender.Attack(attacker));
                }

            }
             
            if (attacker.HP <= 0)
            {
              
              System.Console.WriteLine("Attacker " + attacker.GetType().Name + " died!");
              System.Console.WriteLine("GAME OVER");
              System.Environment.Exit(0); 
              
            }
            if (defender.HP <= 0)
            {
                System.Console.WriteLine("Defender " + defender.GetType().Name + " died!");
            }

        }
}




