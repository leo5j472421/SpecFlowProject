namespace SpecFlowProject.Helper
{
    public static class TennisHelper
    {
        public static string GetScoreDisplay(int firstScore, int secondScore)
        {
            var result = "";
            if (firstScore == secondScore)
            {
                switch (secondScore)
                {
                    case 0:
                        result = "Love All";
                        break;
                    case 1:
                        result = "Fifteen All";
                        break;
                    case 2:
                        result = "Thirty All";
                        break;
                    default:
                        result = "Deuce";
                        break;
                }
            }
            else if (firstScore == 0 )
            {
                
                switch(secondScore)
                {
                    case 0:
                        result = "Love All";
                        break;
                    case 1:
                        result = "Love Fifteen";
                        break;
                    case 2:
                        result = "Love Thirty";
                        break;
                    case 3:
                        result = "Love Forty";
                        break;
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