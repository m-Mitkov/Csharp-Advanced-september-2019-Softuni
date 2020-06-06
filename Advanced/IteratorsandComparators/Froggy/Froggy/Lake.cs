using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stones;
        public Lake(params int[] input)
        {
            this.stones = input.ToList();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Count; i+=2)
            {
                yield return stones[i];
            }

            int reversedStart = this.stones.Count % 2 != 0
                ? stones.Count - 2
                : stones.Count - 1;

            for (int i = reversedStart; i >= 0; i-=2)
            {
                yield return stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
    }
