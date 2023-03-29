

namespace FormsMultidimensional_2023_II
{
    class Matriz
    {
        private int m;
        private int n;

        public int M { 
            get => m;
            set {

                if(m >0   )
                {
                    m = value;
                }
                else
                {
                    m = 1;
                }               
                    
               } 
        }
        public int N {
            get => n;
            set
            {
                if( n > 0)
                {
                    n = value;
                }
                else
                {
                    n = 1;
                }
                
            }
        }
    }
}
