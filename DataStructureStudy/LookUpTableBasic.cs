using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureStudy
{
    /*
    class LookUpTableBasic
    {
        static void Main()
        {
            // 예제 데이터
            var _data = new[]
            {
            new { Category = "Fruit", Item = "Apple" },
            new { Category = "Fruit", Item = "Banana" },
            new { Category = "Vegetable", Item = "Carrot" },
            new { Category = "Fruit", Item = "Orange" },
            new { Category = "Vegetable", Item = "Broccoli" },
            new { Category = "Meat", Item = "Chicken" },
            new { Category = "Meat", Item = "Beef" },
        };

            // Lookup 테이블 생성
            var _lookupTable = _data.ToLookup(item => item.Category);

            // Fruit 카테고리의 모든 항목 출력
            Console.WriteLine("Items in the 'Fruit' category:");
            foreach (var item in _lookupTable["Fruit"])
            {
                Console.WriteLine(item.Item);
            }

            // Vegetable 카테고리의 모든 항목 출력
            Console.WriteLine("\nItems in the 'Vegetable' category:");
            foreach (var item in _lookupTable["Vegetable"])
            {
                Console.WriteLine(item.Item);
            }

            // Meat 카테고리의 모든 항목 출력
            Console.WriteLine("\nItems in the 'Meat' category:");
            foreach (var item in _lookupTable["Meat"])
            {
                Console.WriteLine(item.Item);
            }
        }
    }
    */
}
