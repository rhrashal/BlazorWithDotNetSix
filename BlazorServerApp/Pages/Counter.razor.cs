namespace BlazorServerApp.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;
        private string fontFamily = "Monotype Corsiva";
        private string isShow = "block";
        private void IncrementCount()
        {
            currentCount++;
            isShow = "block";
            if (currentCount == 10)
            {
                isShow = "None";
            }
        }
    }
}
