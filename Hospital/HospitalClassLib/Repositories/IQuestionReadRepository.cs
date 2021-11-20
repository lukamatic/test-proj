﻿using Hospital.Model;
using Hospital.Repositories.Base;

namespace Hospital.Repositories
{
    public interface IQuestionReadRepository : IReadBaseRepository<int, Question>
    {
    }
}