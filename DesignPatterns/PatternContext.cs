namespace DesignPatterns
{
    public class PatternContext
    {
        private IPatterns _contextPatterns;

        public PatternContext()
        { }
        
        public PatternContext(IPatterns contextPatterns)
        {
            _contextPatterns = contextPatterns;
        }

        public void SetPattern(IPatterns patterns)
        {
            _contextPatterns = patterns; 
        }

        public void StartPattern()
        {
            _contextPatterns.MainCall();
        }
    }
}