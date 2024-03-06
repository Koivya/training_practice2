namespace Task2_3_3
{
    internal class Calculation
    {
        private string calculationLine;

        public Calculation(string calculationLine)
        {
            this.calculationLine = calculationLine;
        }

        public void SetCalculationLine(string value)
        {
            calculationLine = value;
        }

        public void SetLastSymbolCalculationLine(string value)
        {
            calculationLine += value;
        }

        public string GetCalculationLine()
        {
            return calculationLine;
        }

        public char GetLastSymbol()
        {
            return calculationLine[calculationLine.Length - 1];
        }

        public void DeleteLastSymbol()
        {
            calculationLine = calculationLine.Substring(0, calculationLine.Length - 1);
        }
    }
}
