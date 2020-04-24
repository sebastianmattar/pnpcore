﻿using PnP.Core.QueryModel.Model;
using PnP.Core.Services;
using System.ComponentModel;

namespace PnP.Core.Model.SharePoint
{
    /// <summary>
    /// Collection of List Domain Model objects
    /// </summary>
    internal partial class ListCollection : QueryableDataModelCollection<IList>, IListCollection
    {
        public ListCollection(PnPContext context, IDataModelParent parent)
            : base(context, parent)
        {
            this.PnPContext = context;
            this.Parent = parent;
        }

        // PAOLO: It looks like this method is not used
        //public override IList Add()
        //{
        //    return AddNewList();
        //}

        public override IList CreateNew()
        {
            return NewList();
        }

        private List AddNewList()
        {
            var newList = NewList();
            this.items.Add(newList);
            return newList;
        }

        private List NewList()
        {
            var newList = new List
            {
                PnPContext = this.PnPContext,
                Parent = this,
            };
            return newList;
        }
    }
}