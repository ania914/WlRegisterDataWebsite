﻿using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WLRegisterDataWebsite.Module.BusinessObjects;

namespace WLRegisterDataWebsite.Module.Controllers.SearchControllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class SearchActionController : ViewController
    {
        private const string SearchActionName = "SearchAction";
        private SimpleAction searchAction;
        public SearchActionController()
        {
            InitializeComponent();
            TargetObjectType = typeof(SearchSubject);
            searchAction = new SimpleAction(this, SearchActionName, PredefinedCategory.View)
            {
                Caption = "Search"
            };
            searchAction.Execute += SearchAction_Execute;
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
            searchAction.Execute -= SearchAction_Execute;
        }

        private void SearchAction_Execute(object sender, SimpleActionExecuteEventArgs e)
        {

        }
    }
}
