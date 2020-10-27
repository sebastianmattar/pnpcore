﻿namespace PnP.Core.Model.SharePoint
{
    [GraphType]
    internal partial class TermLocalizedLabel : BaseDataModel<ITermLocalizedLabel>, ITermLocalizedLabel
    {
        public string LanguageTag { get => GetValue<string>(); set => SetValue(value); }

        public string Name { get => GetValue<string>(); set => SetValue(value); }

        public bool IsDefault { get => GetValue<bool>(); set => SetValue(value); }

        [KeyProperty(nameof(LanguageTag))]
        public override object Key { get => this.LanguageTag; set => this.LanguageTag = value.ToString(); }
    }
}