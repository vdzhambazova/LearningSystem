using LearningSystem.Data;

namespace LearningSystem.Services
{
    public abstract class Service
    {
        protected Service()
        {
            this.Context = new LearningSystemContext();
        }
        public LearningSystemContext Context { get; }
    }
}
