using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
interface總結
 * interface像是契約,要求實作的class需要具備指定的能力
 * 命名習慣以大寫I開頭
 * 跟繼承不同,一個class可以實作多個interface
 * 實作interface定義的method必須
    -->不可以是static
    -->必須是public
    -->signature(輸入值,名稱,輸出值)必須完全相同
 * 繼承不同base class的class也能時做相同的interface
   ex.假設有一個陷阱類別,陷阱當然不是生物類,但同樣可以具有attack能力(可以要求陷阱實作iAttackable)
*/
namespace Interface_demo
{
    interface IAttackable
    {
        /// interface只定義method的長相,作法交給子類去實作
        void attack(Creature target);
    }
}
