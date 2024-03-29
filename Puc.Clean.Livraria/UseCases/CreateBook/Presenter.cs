﻿using Microsoft.AspNetCore.Mvc;
using Puc.Clean.Livraria.Application;
using Puc.Clean.Livraria.Application.UseCases.Common;
using Puc.Clean.Livraria.Application.UseCases.CreateBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Puc.Clean.Livraria.UseCases.CreateBook
{
    public class Presenter : IOutputBoundary<BookOutput>
    {
        public IActionResult ViewModel { get; private set; }
        public BookOutput Output { get; private set; }

        public void Populate(BookOutput response)
        {
            Output = response;

            if (response == null)
            {
                ViewModel = new NoContentResult();
                return;
            }

            ViewModel = new ObjectResult(new Model(response.Name));
        }
    }
}
