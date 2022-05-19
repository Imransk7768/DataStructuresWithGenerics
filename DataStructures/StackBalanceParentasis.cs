namespace DataStructures
{
    public class StackBalanceParentasis<T>
    {
        public void StackBalParentasis<T>()
        {
            int cnt = -1;
            int[] intr = new int[17] { '(', '2', '+', '4', ')', '*', '(', '5', '+', '6', ')', '/', '(', '5', '+', '4', ')' };
            int n = intr.Length;
            char[] ch = new char[17];
            for (int i = 0; i < n; i++)
            {
                if (intr[i] == '(')
                {
                    cnt = cnt + 1;
                    ch[cnt] = '(';
                }
                if (intr[i] == ')' && ch[cnt] == '(')
                {
                    cnt = cnt - 1;
                }
            }
            if (cnt == -1)
            {
                Console.WriteLine("String is Balanced: ");
            }
            else
            {
                Console.WriteLine("String is Un-Balanced: ");
            }
        }
    }
}