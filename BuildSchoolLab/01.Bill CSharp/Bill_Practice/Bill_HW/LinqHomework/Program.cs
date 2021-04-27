using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //影片資料集合
            List<Video> videoList = new List<Video>()
            {
                new Video() { Name = "天竺鼠車車", Country = "日本", Duration = 2.6, Type = "動漫" },
                new Video() { Name = "鬼滅之刃", Country = "日本", Duration = 25, Type = "動漫" },
                new Video() { Name = "鬼滅之刃-無限列車", Country = "日本", Duration = 100, Type = "電影" },
                new Video() { Name = "甜蜜家園SweetHome", Country = "韓國", Duration = 50, Type = "影集" },
                new Video() { Name = "The 100 地球百子", Country = "歐美", Duration = 48, Type = "影集" },
                new Video() { Name = "冰與火之歌Game of thrones", Country = "歐美", Duration = 60, Type = "影集" },
                new Video() { Name = "半澤直樹", Country = "日本", Duration = 40, Type = "影集" },
                new Video() { Name = "古魯家族：新石代", Country = "歐美", Duration = 90, Type = "電影" },
                new Video() { Name = "角落小夥伴電影版：魔法繪本裡的新朋友", Country = "日本", Duration = 77, Type = "電影" },
                new Video() { Name = "TENET天能", Country = "歐美", Duration = 80, Type = "電影" },
                new Video() { Name = "倚天屠龍記2019", Country = "中國", Duration = 58, Type = "影集" },
                new Video() { Name = "下一站是幸福", Country = "中國", Duration = 45, Type = "影集" },
            };

            //人物資料集合
            List<Person> personList = new List<Person>()
            {
                new Person() { Name = "Bill", CountryPrefer = new List<string>() { "中國", "日本" }, TypePrefer = new List<string>() { "影集" } },
                new Person() { Name = "Jimmy", CountryPrefer = new List<string>() { "日本" }, TypePrefer = new List<string>() { "動漫", "電影" } },
                new Person() { Name = "Andy", CountryPrefer = new List<string>() { "歐美", "日本" }, TypePrefer = new List<string>() { "影集", "電影" } },
            };

            // 1. 找出所有日本的影片名稱
            Console.WriteLine($"{Environment.NewLine}Q: 找出所有日本的影片名稱");

            var jpvedio = videoList.Where(x => x.Country == "日本");
            foreach (Video jp in jpvedio)
            {
                Console.WriteLine($"{jp.Name}");
            }

            // 2. 找出所有歐美的影片且類型為"影集"的影片名稱
            Console.WriteLine($"{Environment.NewLine}Q: 找出所有歐美的影片且類型為'影集'的影片名稱");
            var esvedio = videoList.Where(x => x.Country == "歐美").Where(x => x.Type == "影集");
            foreach (Video es in esvedio)
            {
                Console.WriteLine($"{es.Name}");
            }

            // 3. 是否有影片片長超過120分鐘的影片
            Console.WriteLine($"{Environment.NewLine}Q: 是否有影片片長超過120分鐘的影片");
            var longvedio = videoList.Select(x => x.Duration > 120);
            bool i = true;
            foreach (bool l in longvedio)
            {
                if (!l)
                {
                    i = false;
                }
                else
                {
                    i = true;
                }
            }
            Console.WriteLine($"{i}");
            // 4. 請列出所有人的名稱，並且用大寫英文表示，ex: Bill -> BILL
            Console.WriteLine($"{Environment.NewLine}Q: 請列出所有人的名稱，並且用大寫英文表示");
            var person = personList.Select(x => x.Name);
            foreach (string name in person)
            {
                Console.WriteLine(name.ToUpper());
            }

            // 5. 將所有影片用片長排序(最長的在前)，並顯示排序過的排名以及片名，ex: No1: 天竺鼠車車
            Console.WriteLine($"{Environment.NewLine}Q: 將所有影片用片長排序(最長的在前)，並顯示排序過的排名以及片名");

            var longest = videoList.OrderByDescending(x => x.Duration);
            var length = longest.Count();
            int index = 0;
            foreach (Video movie in longest)
            {
                index++;
                Console.WriteLine($"片長排名{index}：{movie.Name}");
            }
            // 6. 將所有影片進行以"類型"分類，並顯示以下樣式(注意縮排)
            /* 
            動漫:
                天竺鼠車車
                鬼滅之刃
            */
            Console.WriteLine($"{Environment.NewLine}Q: 將所有影片進行以'類型'分類");
            var vedioty = videoList.GroupBy(x => x.Type).Select(x => $"{x.Key}:\n\t{string.Join("\n\t", x.Select(y => y.Name))}");
            Console.WriteLine(string.Join(Environment.NewLine, vedioty));

            // 7. 找到第一個喜歡歐美影片的人
            Console.WriteLine($"{Environment.NewLine}Q: 找到第一個喜歡歐美影片的人");
            var loveus = personList.FirstOrDefault(x => x.TypePrefer.Contains("影集") && x.CountryPrefer.Contains("歐美"));
            Console.WriteLine($"\t{loveus.Name}");

            // 8. 找到每個人喜歡的影片(根據國家以及類型)，ex: Bill: 天竺鼠車車, 倚天屠龍記2019
            Console.WriteLine($"{Environment.NewLine}Q: 找到每個人喜歡的影片");
            var luvp =personList.Select
                (x =>x.Name +":" + string.Join(      
                      ",",videoList.Where(
                            y => x.CountryPrefer.Contains(y.Country) && x.TypePrefer.Contains(y.Type)
                        ).Select(z => z.Name)      
                    ) 
                  )  ;
            Console.WriteLine(string.Join("\n",luvp));

            // 9. 列出所有類型的影片總時長，ex: 動漫: 100min
            Console.WriteLine($"{Environment.NewLine}Q: 列出所有類型的影片總時長");
            //var lnt = videoList.GroupBy(x => x.Type).Select(x => $"{x.Key}:\n{string.Join("\n", x.Select(y =>$"{y.Name}~{y.Duration}" ))}");
            var lnt = videoList.GroupBy(x => x.Type).Select(x => $"{x.Key}:共{string.Join("\n", x.Select(y => y.Duration).Sum())}分鐘");
            Console.WriteLine(string.Join("\n",lnt));

            // 10. 列出所有國家出產的影片數量，ex: 日本: 3部
            Console.WriteLine($"{Environment.NewLine}Q: 列出所有國家出產的影片數量");
            var cnvd = videoList.GroupBy(x => x.Country).Select(x => $"{x.Key}: {x.Count()}");
            Console.WriteLine(string.Join("\n",cnvd));
            Console.ReadLine();

        }
    }
}
