using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG_Battle
{
    class Character
    {
        public string Name { get; set; }
        public int HitPoint { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public bool Dead { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Character Enemy1 = new Character();
            Enemy1.Name = "校長先生";
            Enemy1.HitPoint = 100;
            Enemy1.Attack = 20;
            Enemy1.Defence = 10;
            Enemy1.Dead = false;

            Character Enemy2 = new Character();
            Enemy2.Name = "教頭先生";
            Enemy2.HitPoint = 50;
            Enemy2.Attack = 16;
            Enemy2.Defence = 2;
            Enemy2.Dead = false;

            Character Enemy3 = new Character();
            Enemy3.Name = "校長先生（元教頭）";
            Enemy3.HitPoint = 500;
            Enemy3.Attack = 80;
            Enemy3.Defence = 20;

            Character Player =new Character();
            Player.Name = "あなた";
            Player.HitPoint = 250;
            Player.Attack =50;
            Player.Defence = 2;
        
            Console.Write(Enemy1.Name + "HP" + Enemy1.HitPoint + "\n");
            Console.Write(Enemy2.Name + "HP" + Enemy2.HitPoint + "\n\n\n");
            Console.Write(Player.Name + "HP" + Player.HitPoint + "\n\n");
            Console.Write("校長先生「お前がどこの馬の骨か知らんが歯向かったことを後悔させてやる」\n教頭先生「ええ、ええ、校長のおっしゃる通りに……」\n");
            Thread.Sleep(3500);
            Console.Write("敵が現れた!\n");
            Thread.Sleep(2000);
            Console.Clear();

            Console.Write(Enemy1.Name+"HP"+Enemy1.HitPoint+"\n");
            Console.Write(Enemy2.Name + "HP" + Enemy2.HitPoint+"\n\n\n");
            Console.Write(Player.Name + "HP" + Player.HitPoint + "\n\n");

            Console.Write("コマンド？\n");
            Console.Write("{0}を攻撃する：Ａキーを押してください\n{1}を攻撃する：Ｂキーを押してください\n", Enemy1.Name, Enemy2.Name);

            int aRead = 1;
            while(aRead==1)
            {
                if(Player.HitPoint<=0)
                {
                    break;
                }
                ConsoleKeyInfo c = Console.ReadKey(true);
                if(c.Key.ToString()=="A")
                {
                    if (Enemy2.Dead == false)
                    {
                        int tmp = Enemy1.HitPoint;
                        Enemy1.HitPoint = tmp - (Player.Attack - Enemy1.Defence);

                        Console.Clear();
                        Console.Write(Enemy1.Name + "HP" + Enemy1.HitPoint + "\n");
                        Console.Write(Enemy2.Name + "HP" + Enemy2.HitPoint + "\n\n\n");
                        Console.Write(Player.Name + "HP" + Player.HitPoint + "\n\n");
                        Console.Write("{0}は{1}を攻撃した。{1}に{2}のダメージ", Player.Name, Enemy1.Name, Player.Attack - Enemy1.Defence);
                        Thread.Sleep(2500);
                        Console.Clear();

                        Console.Write("\n");
                        Console.Write(Enemy2.Name + "HP" + Enemy2.HitPoint + "\n\n\n");
                        Console.Write(Player.Name + "HP" + Player.HitPoint + "\n\n");
                        //Console.Write("コマンド？\n");
                        //Console.Write("{0}を攻撃する：Ａキーを押してください\n{1}を攻撃する：Ｂキーを押してください\n",Enemy1.Name,Enemy2.Name);
                        Console.Write("{0}は{1}を攻撃した。{1}に{2}のダメージ", Player.Name, Enemy1.Name, Player.Attack - Enemy1.Defence);
                        Thread.Sleep(600);
                        Console.Clear();
                        if (Enemy1.HitPoint == 0)
                        {
                            aRead = 2;
                            break;
                        }

                        Console.Write(Enemy1.Name + "HP" + Enemy1.HitPoint + "\n");
                        Console.Write(Enemy2.Name + "HP" + Enemy2.HitPoint + "\n\n\n");
                        Console.Write(Player.Name + "HP" + Player.HitPoint + "\n\n");

                        //Console.Write("コマンド？\n");
                        //Console.Write("{0}を攻撃する：Ａキーを押してください\n{1}を攻撃する：Ｂキーを押してください\n\n", Enemy1.Name, Enemy2.Name);

                        Console.Write("{0}の攻撃\n", Enemy1.Name);
                        Console.Write("{0}は{1}を攻撃した。{1}に{2}のダメージ\n", Enemy1.Name, Player.Name, Enemy1.Attack - Player.Defence);
                        int tmp2 = Player.HitPoint;
                        Player.HitPoint = tmp2 - (Enemy1.Attack - Player.Defence);
                        Console.Write("{0}の攻撃\n", Enemy2.Name);
                        Console.Write("{0}は{1}を攻撃した。{1}に{2}のダメージ\n", Enemy2.Name, Player.Name, Enemy2.Attack - Player.Defence);
                        Player.HitPoint = tmp2 - (Enemy1.Attack - Player.Defence);

                        Thread.Sleep(3500);
                        Console.Clear();
                        Console.Write(Enemy1.Name + "HP" + Enemy1.HitPoint + "\n");
                        Console.Write(Enemy2.Name + "HP" + Enemy2.HitPoint + "\n\n\n");
                        Console.Write(Player.Name + "HP" + Player.HitPoint + "\n\n");

                        Console.Write("コマンド？\n");
                        Console.Write("{0}を攻撃する：Ａキーを押してください\n{1}を攻撃する：Ｂキーを押してください\n", Enemy1.Name, Enemy2.Name);
                    }
                    if(Enemy2.Dead==true)
                    {
                        int tmp = Enemy1.HitPoint;
                        Enemy1.HitPoint = tmp - (Player.Attack - Enemy1.Defence);
                        Console.Clear();
                        Console.Write(Enemy1.Name + "HP" + Enemy1.HitPoint + "\n");
                        Console.Write("\n\n\n");
                        Console.Write(Player.Name + "HP" + Player.HitPoint + "\n\n");
                        Console.Write("{0}は{1}を攻撃した。{1}に{2}のダメージ", Player.Name, Enemy1.Name, Player.Attack - Enemy1.Defence);
                        Thread.Sleep(2500);
                        Console.Clear();

                        Console.Write("\n");
                        Console.Write("\n\n\n");
                        Console.Write(Player.Name + "HP" + Player.HitPoint + "\n\n");
                        //Console.Write("コマンド？\n");
                        //Console.Write("{0}を攻撃する：Ａキーを押してください\n{1}を攻撃する：Ｂキーを押してください\n",Enemy1.Name,Enemy2.Name);
                        Console.Write("{0}は{1}を攻撃した。{1}に{2}のダメージ", Player.Name, Enemy1.Name, Player.Attack - Enemy1.Defence);
                        Thread.Sleep(600);
                        Console.Clear();
                        if (Enemy1.HitPoint == 0)
                        {
                            aRead = 2;
                            break;
                        }

                        Console.Write(Enemy1.Name + "HP" + Enemy1.HitPoint + "\n");
                        Console.Write("\n\n\n");
                        Console.Write(Player.Name + "HP" + Player.HitPoint + "\n\n");

                        //Console.Write("コマンド？\n");
                        //Console.Write("{0}を攻撃する：Ａキーを押してください\n{1}を攻撃する：Ｂキーを押してください\n\n", Enemy1.Name, Enemy2.Name);

                        Console.Write("{0}の攻撃\n", Enemy1.Name);
                        Console.Write("{0}は{1}を攻撃した。{1}に{2}のダメージ\n", Enemy1.Name, Player.Name, Enemy1.Attack - Player.Defence);
                        int tmp2 = Player.HitPoint;
                        Player.HitPoint = tmp2 - (Enemy1.Attack - Player.Defence);
                        //Console.Write("{0}の攻撃\n", Enemy2.Name);
                        //Console.Write("{0}は{1}を攻撃した。{1}に{2}のダメージ\n", Enemy2.Name, Player.Name, Enemy2.Attack - Player.Defence);
                        //Player.HitPoint = tmp2 - (Enemy1.Attack - Player.Defence);

                        Thread.Sleep(3500);
                        Console.Clear();
                        Console.Write(Enemy1.Name + "HP" + Enemy1.HitPoint + "\n");
                        Console.Write("\n\n\n");
                        Console.Write(Player.Name + "HP" + Player.HitPoint + "\n\n");

                        Console.Write("コマンド？\n");
                        Console.Write("{0}を攻撃する：Ａキーを押してください\n{1}を攻撃する：Ｂキーを押してください\n", Enemy1.Name, Enemy2.Name);
                    }
                }
                if (Enemy2.Dead == false)
                {
                    if (c.Key.ToString() == "B")
                    {
                        int tmp = Enemy2.HitPoint;
                        Enemy2.HitPoint = tmp - (Player.Attack - Enemy2.Defence);
                        Console.Clear();
                        Console.Write(Enemy1.Name + "HP" + Enemy1.HitPoint + "\n");
                        Console.Write(Enemy2.Name + "HP" + Enemy2.HitPoint + "\n\n\n");
                        Console.Write(Player.Name + "HP" + Player.HitPoint + "\n\n");
                        Console.Write("{0}は{1}を攻撃した。{1}に{2}のダメージ", Player.Name, Enemy2.Name, Player.Attack - Enemy2.Defence);
                        Thread.Sleep(2500);
                        Console.Clear();

                        Console.Write(Enemy1.Name + "HP" + Enemy1.HitPoint + "\n");
                        Console.Write("\n\n\n");
                        Console.Write(Player.Name + "HP" + Player.HitPoint + "\n\n");
                        //Console.Write("コマンド？\n");
                        //Console.Write("{0}を攻撃する：Ａキーを押してください\n{1}を攻撃する：Ｂキーを押してください\n", Enemy1.Name, Enemy2.Name);
                        Console.Write("{0}は{1}を攻撃した。{1}に{2}のダメージ\n", Player.Name, Enemy2.Name, Player.Attack - Enemy2.Defence);

                        Thread.Sleep(600);
                        Console.Clear();

                        Console.Write(Enemy1.Name + "HP" + Enemy1.HitPoint + "\n");
                        Console.Write(Enemy2.Name + "HP" + Enemy2.HitPoint + "\n\n\n");
                        Console.Write(Player.Name + "HP" + Player.HitPoint + "\n\n");

                        if (Enemy2.HitPoint <= 0)
                        {
                            Console.Write("{0}は死んだ\n", Enemy2.Name);
                            Enemy2.Dead = true;
                        }
                        //Console.Write("コマンド？\n");
                        //Console.Write("{0}を攻撃する：Ａキーを押してください\n{1}を攻撃する：Ｂキーを押してください\n\n", Enemy1.Name, Enemy2.Name);
                        if (Enemy2.Dead == false)
                        {
                            Console.Write("{0}の攻撃\n", Enemy1.Name);
                            Console.Write("{0}は{1}を攻撃した。{1}に{2}のダメージ\n", Enemy1.Name, Player.Name, Enemy1.Attack - Player.Defence);
                            int tmp2 = Player.HitPoint;
                            Player.HitPoint = tmp2 - (Enemy1.Attack - Player.Defence);
                            Console.Write("{0}の攻撃\n", Enemy2.Name);
                            Console.Write("{0}は{1}を攻撃した。{1}に{2}のダメージ\n", Enemy2.Name, Player.Name, Enemy2.Attack - Player.Defence);
                            Player.HitPoint = tmp2 - (Enemy1.Attack - Player.Defence);

                            Thread.Sleep(3500);
                            Console.Clear();
                            Console.Write(Enemy1.Name + "HP" + Enemy1.HitPoint + "\n");
                            Console.Write(Enemy2.Name + "HP" + Enemy2.HitPoint + "\n\n\n");
                            Console.Write(Player.Name + "HP" + Player.HitPoint + "\n\n");

                            Console.Write("コマンド？\n");
                            Console.Write("{0}を攻撃する：Ａキーを押してください\n{1}を攻撃する：Ｂキーを押してください\n", Enemy1.Name, Enemy2.Name);
                        }

                        if (Enemy2.Dead == true)
                        {
                            Console.Write("{0}の攻撃\n", Enemy1.Name);
                            Console.Write("{0}は{1}を攻撃した。{1}に{2}のダメージ\n", Enemy1.Name, Player.Name, Enemy1.Attack - Player.Defence);
                            int tmp2 = Player.HitPoint;
                            Player.HitPoint = tmp2 - (Enemy1.Attack - Player.Defence);
                            //Console.Write("{0}の攻撃\n", Enemy2.Name);
                            //Console.Write("{0}は{1}を攻撃した。{1}に{2}のダメージ\n", Enemy2.Name, Player.Name, Enemy2.Attack - Player.Defence);
                            //Player.HitPoint = tmp2 - (Enemy1.Attack - Player.Defence);

                            Thread.Sleep(3500);
                            Console.Clear();
                            Console.Write(Enemy1.Name + "HP" + Enemy1.HitPoint + "\n");
                            Console.Write("\n\n\n");
                            Console.Write(Player.Name + "HP" + Player.HitPoint + "\n\n");

                            Console.Write("コマンド？\n");
                            Console.Write("{0}を攻撃する：Ａキーを押してください\n", Enemy1.Name);
                        }

                    }
                }
                //Console.Write("{0}の攻撃\n", Enemy1.Name);
                //Console.Write("{0}は{1}を攻撃した。{1}に{2}のダメージ\n", Enemy1.Name, Player.Name, Enemy1.Attack - Player.Defence);
                //int tmp2 = Player.HitPoint;
                //Player.HitPoint = tmp2 - (Enemy1.Attack - Player.Defence);
                //Console.Write("{0}の攻撃\n", Enemy2.Name);
                //Console.Write("{0}は{1}を攻撃した。{1}に{2}のダメージ\n", Enemy2.Name, Player.Name, Enemy2.Attack - Player.Defence);
                //Player.HitPoint = tmp2 - (Enemy1.Attack - Player.Defence);

                //Thread.Sleep(1500);
                //Console.Clear();
                //Console.Write(Enemy1.Name + "HP" + Enemy1.HitPoint + "\n");
                //Console.Write(Enemy2.Name + "HP" + Enemy2.HitPoint + "\n\n\n");
                //Console.Write(Player.Name + "HP" + Player.HitPoint + "\n\n");

                //Console.Write("コマンド？\n");
                //Console.Write("{0}を攻撃する：Ａキーを押してください\n{1}を攻撃する：Ｂキーを押してください\n", Enemy1.Name, Enemy2.Name);
            if(Enemy1.HitPoint<=0)
            {
                Enemy1.Dead = true;
                aRead = 2;
            }
            }
            if(Player.HitPoint<=0)
            {
                Console.Write("あなた「ごぼっ…………く…………そ…………」\n志半ばであなたは死にました、それは何もしていないのと一緒なのです、勝ってください。");
            }
            if (Enemy1
                .HitPoint <= 0)
            {
                Console.Clear();
                Console.Write("{0}「ぐぅおぉぉぉおぉ、お前は何者だ、この私を…………いや、お前のその顔、どこかで…………………うっ…………………」\n{0}はそのままがっくりと地に伏して息絶えた。\n\n", Enemy1.Name);
                Thread.Sleep(5000);
                Console.Write("{0}「はぁっ、はぁっ、校長を倒した。これでこの学校は平和になるはずだ……、！！」\n", Player.Name);
                Thread.Sleep(4000);
                Console.Write("???「ふはっ、フハハハハハ」\n");
                Thread.Sleep(6000);
                Console.Write("地の底から響くような声がどこからともなく聞こえてくる。\nそして、むくりと、倒れていた{0}が立ち上がった。\n", Enemy2.Name);
                Thread.Sleep(5000);
                Console.Write("{0}「お前が校長を倒してくれた。そして、そのおかげで私がやっと校長になることが出来るのだ。フハハハハ。誰かは知らんが君に感謝するぞ！」\n", Enemy2.Name);
                Thread.Sleep(6000);

                for (int x = 0; x <= 3; ++x)
                {
                    Console.Clear();
                    Thread.Sleep(500);
                    Console.Write("{0}「ぐぅおぉぉぉおぉ、お前は何者だ、この私を…………いや、お前のその顔、どこかで……………………………………」\n{0}はそのままがっくりと地に伏して息絶えた。\n\n", Enemy1.Name);
                    Console.Write("{0}「はぁっ、はぁっ、校長を倒した。これでこの学校は平和になるはずだ……、！！」\n", Player.Name);
                    Console.Write("???「ふはっ、フハハハハハ」\n");
                    Console.Write("地の底から響くような声がどこからともなく聞こえてくる。\nそして、むくりと、倒れていた{0}が立ち上がった。\n", Enemy2.Name);
                    Console.Write("{0}「お前が校長を倒してくれた。そして、そのおかげで私がやっと校長になることが出来るのだ。フハハハハ。誰かは知らんが君に感謝するぞ！」\n", Enemy2.Name);
                    Thread.Sleep(500);
                }

                Console.Clear();
                Console.Write("校長先生（元教頭）「はぁぁあ、みなぎるぞ、校長力。私こそが生まれながらにして校長にふさわしい男だとは思わんかね？」\n敵が現れた！");
                Thread.Sleep(6500);
                Console.Clear();

                while (aRead == 2)
                {
                    Console.Write(Enemy3.Name + "HP" + Enemy3.HitPoint + "\n\n");
                    Console.Write(Player.Name + "HP" + Player.HitPoint + "\n\n");

                    Console.Write("コマンド？\n");
                    Console.Write("{0}を攻撃する：Ａキーを押してください\n", Enemy3.Name);
                    ConsoleKeyInfo c = Console.ReadKey(true);
                  
                    if (c.Key.ToString() == "A")
                    {
                        int tmp = Enemy3.HitPoint;
                        Enemy3.HitPoint = tmp - (Player.Attack - Enemy3.Defence);
                        Console.Clear();
                        Console.Write(Enemy3.Name + "HP" + Enemy3.HitPoint + "\n\n");
                        Console.Write(Player.Name + "HP" + Player.HitPoint + "\n\n");
                        Console.Write("{0}は{1}を攻撃した。{1}に{2}のダメージ", Player.Name, Enemy3.Name, Player.Attack - Enemy3.Defence);
                        Thread.Sleep(2500);
                        Console.Clear();

                        int tmp2 = Player.HitPoint;
                        Player.HitPoint = tmp2 - (Enemy3.Attack - Player.Defence);
                        if (Player.HitPoint <= 0)
                        {
                            Player.HitPoint = 0;
                        }
                        Console.Write(Enemy3.Name + "HP" + Enemy3.HitPoint + "\n\n");
                        Console.Write(Player.Name + "HP" + Player.HitPoint + "\n\n");

                        Console.Write("{0}は{1}を攻撃した。{1}に{2}のダメージ" ,Enemy3.Name, Player.Name, Enemy3.Attack - Player.Defence);
                        Thread.Sleep(2500);
                        Console.Clear();
                        
                       
                        //Console.Write(Enemy3.Name + "HP" + Enemy3.HitPoint + "\n\n");
                        //Console.Write(Player.Name + "HP" + Player.HitPoint + "\n\n");

                        //Console.Write("コマンド？\n");
                        //Console.Write("{0}を攻撃する：Ａキーを押してください\n", Enemy3.Name);
                    }
                    if (Player.HitPoint <= 0)
                    {
                        aRead = 3;

                        Console.Clear();
                        Console.Write(Enemy3.Name +"HP"+ Enemy3.HitPoint + "\n\n");
                        Console.Write(Player.Name + "HP" + Player.HitPoint + "\n\n");

                        Console.Write("あなた「ぐっ………ごぼっ………」\n教頭先生「最後に名前くらいは聞いといてやろう、フハハハハハ！」\n");
                        Thread.Sleep(4000);
                        Console.Write("あなた「……はぁっはぁっ…………僕はあなたです」\n");
                        Thread.Sleep(4000);
                        Console.Write("教頭先生「何？……、まさか、そんな、なんだこれは、グハッ」\n");
                        Thread.Sleep(4000);
                        Console.Clear();
                        Console.Write(Enemy3.Name + "HP" + "30"+ "\n\n");
                        Console.Write(Player.Name + "HP" + Player.HitPoint + "\n\n");

                        Console.Write("あなた「ぐっ………ごぼっ………」\n教頭先生「最後に名前くらいは聞いといてやろう、フハハハハハ！」\n");
                        Console.Write("あなた「……はぁっはぁっ…………僕はあなたです」\n");
                        Console.Write("教頭先生「何？……、まさか、そんな、なんだこれは、グハッ」\n");
                        Thread.Sleep(4000);
                        Console.Write("あなた「……腐りきってしまった。……うっ、昔は教育にかける熱意は誰にも負けなかった」\n");
                        Thread.Sleep(4000);
                        Console.Write("教頭先生「うっ、お前が、私だと言うのか、お前が若かりし頃の私の情熱とでも？」\n");
                        Thread.Sleep(4000);
                        Console.Write("あなた「……自分を殺すようでは、もうおしまいです」\n");
                        Thread.Sleep(4000);
                        Console.Clear();
                        Console.Write("あなた「うっ……」あなたが息を引き取るのと同時に、教頭先生は息を引き取った。\n\n全ては終わったのだ――End 学園物語～ドッペルゲンガーの宿命～");


                    }

                }
            }
            Console.Read();

        }
    }
}
