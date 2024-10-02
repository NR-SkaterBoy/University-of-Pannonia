using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Gyak_1_kiszh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LoadDataFromJson
            try
            {
                string jsonPath = "./testresults.json";

                if (File.Exists(jsonPath))
                {
                    Result.LoadDataFromJson(jsonPath);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine($"Hiba történt az IO művelet közben: {e.Message}");
            }
            catch (JsonException e)
            {
                Console.WriteLine($"Hiba található a JSON dokumentumban: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Hiba történt: {e.Message}");
            }
            #endregion

            //#region FindGroupByScoreAndTime
            //Console.WriteLine("Finding scores:");
            //try { Result.FindGroupByScoreAndTime(80, 25); } catch (Exception e) { Console.WriteLine($"Hiba történt: {e.Message}"); }
            //try { Result.FindGroupByScoreAndTime(90, 15); } catch (Exception e) { Console.WriteLine($"Hiba történt: {e.Message}"); }
            //#endregion

            //#region AvaragePoint
            //Console.WriteLine();
            //Console.WriteLine("Average scores:");
            //Result.AvaragePoint();
            //#endregion

            //#region FrequentlyMark
            //Console.WriteLine();
            //Console.WriteLine("Most common grades:");
            //Result.FrequentlyMark();
            //#endregion

            //Result.test(80, 25);
            Result.test2();



            Console.ReadKey();
        }
    }
}
