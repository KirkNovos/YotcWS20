using System;

namespace RegZnak
{
    public class REG_MARK
    {

        public class Mark_info
        {

        }


        public Boolean CheckMark(string mark)
        {
            int ti;
            string num1 = (mark.Substring(0, 1));
            string num2 = (mark.Substring(4, 2));
            string dig1 = (mark.Substring(1, 3));
            string dig2 = (mark.Substring(6, 3));

            bool isDig1 = int.TryParse(dig1, out ti);
            bool isDig2 = int.TryParse(dig2, out ti);



            if (char.IsLetter(num1[0]))
            {
                for (int i=0; i<num2.Length; i++)
                {
                    if (char.IsLetter(num2[i]))
                    {
                        if (isDig1)
                        {
                            if (isDig2)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        string GetNextMarkAfter(string mark)
        {
            
        }

    }
}
