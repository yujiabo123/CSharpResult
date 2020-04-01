using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y_Practice
{
    public class Leecode
    {
        /// <summary>
        /// 卡牌分组
        /// 给定一副牌，每张牌上都写着一个整数。
        /// 此时，你需要选定一个数字 X，使我们可以将整副牌按下述规则分成 1 组或更多组：
        /// 每组都有 X张牌。
        /// 组内所有的牌上都写着相同的整数。
        /// 仅当你可选的 X >= 2 时返回 true。
        /// 提示：
        /// 1 <= deck.length <= 10000
        /// 0 <= deck[i] < 10000
        /// </summary>
        /// <param name="deck"></param>
        /// <returns></returns>
        public bool HasGroupsSizeX(int[] deck)
        {
            int N = deck.Length;
            int[] count = new int[10000];
            foreach (var item in deck)
            {
                count[item]++;
            }

            for (int X = 2; X <= N; X++)
            {
                if (N % X == 0)
                {
                    bool isBreak = false;
                    foreach (var item in count)
                    {
                        if (item % X != 0)
                        {
                            isBreak = true;
                            break;
                        }
                    }
                    if (!isBreak)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
