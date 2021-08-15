namespace SpecFlowProject.Helper
{
    public static class TennisHelper
    {
        public static string GetScoreDisplay(int firstScore, int secondScore)
        {
            var result = "";
            if (firstScore == 0 )
            {
                if (secondScore ==0)
                {
                    result = "Love All";
                }
               
            }
            else {
                switch (firstScore)
                {
                    case 1:
                        result = "Fifteen Love";
                        break;
                    case 2:
                        result = "Thirty Love";
                        break;
                    case 3:
                        result = "Forty Love";
                        break;
                }
                
            }

            return result;
        }
    }
}