﻿using Microsoft.AspNetCore.Components;
using OSKManager.Model;
using OSKManager.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSKManager.Web.Pages.AdministratorPages.Calendar
{
    public class AdministratorAddEventBase : ComponentBase
    {
        public List<Category> Categories { get; set; } = new List<Category>();

        [Inject]
        public ICategoryService CategoryService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Categories = (await CategoryService.GetCategories()).OrderBy(x => x.ShortCategory).ToList();
        }
    }
}
