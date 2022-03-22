﻿using OngProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.Interfaces
{
    public interface ITestimonialsBusiness
    {
        public Task<List<testimonials>> GetAll();

        public Task<testimonials> GetById();
        public Task Insert(testimonials __testimonials);
        public Task Update(testimonials __testimonials);
        public Task Delete(testimonials __testimonials);

    }
}
