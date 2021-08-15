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
            else
            {
                result = "Fifteen Love";
            }

            return result;
        }
    }
}