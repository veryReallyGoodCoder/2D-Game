//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.Unity;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Articy.Articy_Draft_Test_Drive
{
    
    
    public class Path : ArticyObject, IPath, IPropertyProvider, IObjectWithColor, IObjectWithDisplayName, IObjectWithUnresolvedDisplayName, IObjectWithPreviewImage, IObjectWithText, IObjectWithUnresolvedText, IObjectWithTransformation, IObjectWithVertices, IObjectWithExternalId, IObjectWithShortId, IObjectWithZIndex, IObjectWithSize
    {
        
        [SerializeField()]
        private String mDisplayName;
        
        [SerializeField()]
        private PreviewImage mPreviewImage = new PreviewImage();
        
        [SerializeField()]
        private ArticyValueListVector2 mVertices = new ArticyValueListVector2();
        
        [SerializeField()]
        private Transformation mTransform = new Transformation();
        
        [SerializeField()]
        private Color mColor;
        
        [SerializeField()]
        private String mText;
        
        [SerializeField()]
        private String mExternalId;
        
        [SerializeField()]
        private Single mZIndex;
        
        [SerializeField()]
        private Vector2 mSize;
        
        [SerializeField()]
        private UInt32 mShortId;
        
        [SerializeField()]
        private VisibilityModes mVisibility = new VisibilityModes();
        
        [SerializeField()]
        private SelectabilityModes mSelectability = new SelectabilityModes();
        
        [SerializeField()]
        private Boolean mShowDisplayName = new Boolean();
        
        [SerializeField()]
        private Color mDisplayNameColor;
        
        [SerializeField()]
        private Int32 mDisplayNameSize;
        
        [SerializeField()]
        private Boolean mDropShadow = new Boolean();
        
        [SerializeField()]
        private Color mOutlineColor;
        
        [SerializeField()]
        private Single mOutlineSize;
        
        [SerializeField()]
        private OutlineStyle mOutlineStyle = new OutlineStyle();
        
        [SerializeField()]
        private PathCaps mStartCap = new PathCaps();
        
        [SerializeField()]
        private PathCaps mEndCap = new PathCaps();
        
        [SerializeField()]
        private Single mLineWidth;
        
        public String Unresolved_DisplayName
        {
            get
            {
                return mDisplayName;
            }
        }
        
        public String DisplayName
        {
            get
            {
                return Articy.Unity.ArticyTextExtension.Resolve(this, mDisplayName);
            }
            set
            {
                var oldValue = mDisplayName;
                mDisplayName = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "DisplayName", oldValue, mDisplayName);
            }
        }
        
        public PreviewImage PreviewImage
        {
            get
            {
                return mPreviewImage;
            }
            set
            {
                var oldValue = mPreviewImage;
                mPreviewImage = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "PreviewImage", oldValue, mPreviewImage);
            }
        }
        
        public List<Vector2> Vertices
        {
            get
            {
                return mVertices.GetValue();
            }
            set
            {
                var oldValue = mVertices;
                mVertices.SetValue(value);
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Vertices", oldValue.GetValue(), mVertices.GetValue());
            }
        }
        
        public Transformation Transform
        {
            get
            {
                return mTransform;
            }
            set
            {
                var oldValue = mTransform;
                mTransform = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Transform", oldValue, mTransform);
            }
        }
        
        public Color Color
        {
            get
            {
                return mColor;
            }
            set
            {
                var oldValue = mColor;
                mColor = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Color", oldValue, mColor);
            }
        }
        
        public String Unresolved_Text
        {
            get
            {
                return mText;
            }
        }
        
        public String Text
        {
            get
            {
                return Articy.Unity.ArticyTextExtension.Resolve(this, mText);
            }
            set
            {
                var oldValue = mText;
                mText = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Text", oldValue, mText);
            }
        }
        
        public String ExternalId
        {
            get
            {
                return mExternalId;
            }
            set
            {
                var oldValue = mExternalId;
                mExternalId = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "ExternalId", oldValue, mExternalId);
            }
        }
        
        public Single ZIndex
        {
            get
            {
                return mZIndex;
            }
            set
            {
                var oldValue = mZIndex;
                mZIndex = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "ZIndex", oldValue, mZIndex);
            }
        }
        
        public Vector2 Size
        {
            get
            {
                return mSize;
            }
            set
            {
                var oldValue = mSize;
                mSize = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Size", oldValue, mSize);
            }
        }
        
        public UInt32 ShortId
        {
            get
            {
                return mShortId;
            }
            set
            {
                var oldValue = mShortId;
                mShortId = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "ShortId", oldValue, mShortId);
            }
        }
        
        public VisibilityModes Visibility
        {
            get
            {
                return mVisibility;
            }
            set
            {
                var oldValue = mVisibility;
                mVisibility = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Visibility", oldValue, mVisibility);
            }
        }
        
        public SelectabilityModes Selectability
        {
            get
            {
                return mSelectability;
            }
            set
            {
                var oldValue = mSelectability;
                mSelectability = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Selectability", oldValue, mSelectability);
            }
        }
        
        public Boolean ShowDisplayName
        {
            get
            {
                return mShowDisplayName;
            }
            set
            {
                var oldValue = mShowDisplayName;
                mShowDisplayName = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "ShowDisplayName", oldValue, mShowDisplayName);
            }
        }
        
        public Color DisplayNameColor
        {
            get
            {
                return mDisplayNameColor;
            }
            set
            {
                var oldValue = mDisplayNameColor;
                mDisplayNameColor = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "DisplayNameColor", oldValue, mDisplayNameColor);
            }
        }
        
        public Int32 DisplayNameSize
        {
            get
            {
                return mDisplayNameSize;
            }
            set
            {
                var oldValue = mDisplayNameSize;
                mDisplayNameSize = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "DisplayNameSize", oldValue, mDisplayNameSize);
            }
        }
        
        public Boolean DropShadow
        {
            get
            {
                return mDropShadow;
            }
            set
            {
                var oldValue = mDropShadow;
                mDropShadow = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "DropShadow", oldValue, mDropShadow);
            }
        }
        
        public Color OutlineColor
        {
            get
            {
                return mOutlineColor;
            }
            set
            {
                var oldValue = mOutlineColor;
                mOutlineColor = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "OutlineColor", oldValue, mOutlineColor);
            }
        }
        
        public Single OutlineSize
        {
            get
            {
                return mOutlineSize;
            }
            set
            {
                var oldValue = mOutlineSize;
                mOutlineSize = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "OutlineSize", oldValue, mOutlineSize);
            }
        }
        
        public OutlineStyle OutlineStyle
        {
            get
            {
                return mOutlineStyle;
            }
            set
            {
                var oldValue = mOutlineStyle;
                mOutlineStyle = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "OutlineStyle", oldValue, mOutlineStyle);
            }
        }
        
        public PathCaps StartCap
        {
            get
            {
                return mStartCap;
            }
            set
            {
                var oldValue = mStartCap;
                mStartCap = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "StartCap", oldValue, mStartCap);
            }
        }
        
        public PathCaps EndCap
        {
            get
            {
                return mEndCap;
            }
            set
            {
                var oldValue = mEndCap;
                mEndCap = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "EndCap", oldValue, mEndCap);
            }
        }
        
        public Single LineWidth
        {
            get
            {
                return mLineWidth;
            }
            set
            {
                var oldValue = mLineWidth;
                mLineWidth = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "LineWidth", oldValue, mLineWidth);
            }
        }
        
        protected override void CloneProperties(object aClone, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Path newClone = ((Path)(aClone));
            newClone.DisplayName = Unresolved_DisplayName;
            newClone.PreviewImage = PreviewImage;
            List<Vector2> temp_Vertices = new List<Vector2>();
            int i = 0;
            for (i = 0; (i < Vertices.Count); i = (i + 1))
            {
                temp_Vertices.Add(Vertices[i]);
            }
            newClone.Vertices = temp_Vertices;
            newClone.Transform = Transform;
            newClone.Color = Color;
            newClone.Text = Unresolved_Text;
            newClone.ExternalId = ExternalId;
            newClone.ZIndex = ZIndex;
            newClone.Size = Size;
            newClone.ShortId = ShortId;
            newClone.Visibility = Visibility;
            newClone.Selectability = Selectability;
            newClone.ShowDisplayName = ShowDisplayName;
            newClone.DisplayNameColor = DisplayNameColor;
            newClone.DisplayNameSize = DisplayNameSize;
            newClone.DropShadow = DropShadow;
            newClone.OutlineColor = OutlineColor;
            newClone.OutlineSize = OutlineSize;
            newClone.OutlineStyle = OutlineStyle;
            newClone.StartCap = StartCap;
            newClone.EndCap = EndCap;
            newClone.LineWidth = LineWidth;
            base.CloneProperties(newClone, aFirstClassParent);
        }
        
        public override bool IsLocalizedPropertyOverwritten(string aProperty)
        {
            return base.IsLocalizedPropertyOverwritten(aProperty);
        }
        
        #region property provider interface
        public override void setProp(string aProperty, object aValue)
        {
            if ((aProperty == "DisplayName"))
            {
                DisplayName = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "PreviewImage"))
            {
                PreviewImage = ((PreviewImage)(aValue));
                return;
            }
            if ((aProperty == "Vertices"))
            {
                Vertices = ((List<Vector2>)(aValue));
                return;
            }
            if ((aProperty == "Transform"))
            {
                Transform = ((Transformation)(aValue));
                return;
            }
            if ((aProperty == "Color"))
            {
                Color = ((Color)(aValue));
                return;
            }
            if ((aProperty == "Text"))
            {
                Text = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "ExternalId"))
            {
                ExternalId = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "ZIndex"))
            {
                ZIndex = System.Convert.ToSingle(aValue);
                return;
            }
            if ((aProperty == "Size"))
            {
                Size = ((Vector2)(aValue));
                return;
            }
            if ((aProperty == "ShortId"))
            {
                ShortId = ((UInt32)(aValue));
                return;
            }
            if ((aProperty == "Visibility"))
            {
                Visibility = ((VisibilityModes)(aValue));
                return;
            }
            if ((aProperty == "Selectability"))
            {
                Selectability = ((SelectabilityModes)(aValue));
                return;
            }
            if ((aProperty == "ShowDisplayName"))
            {
                ShowDisplayName = System.Convert.ToBoolean(aValue);
                return;
            }
            if ((aProperty == "DisplayNameColor"))
            {
                DisplayNameColor = ((Color)(aValue));
                return;
            }
            if ((aProperty == "DisplayNameSize"))
            {
                DisplayNameSize = System.Convert.ToInt32(aValue);
                return;
            }
            if ((aProperty == "DropShadow"))
            {
                DropShadow = System.Convert.ToBoolean(aValue);
                return;
            }
            if ((aProperty == "OutlineColor"))
            {
                OutlineColor = ((Color)(aValue));
                return;
            }
            if ((aProperty == "OutlineSize"))
            {
                OutlineSize = System.Convert.ToSingle(aValue);
                return;
            }
            if ((aProperty == "OutlineStyle"))
            {
                OutlineStyle = ((OutlineStyle)(aValue));
                return;
            }
            if ((aProperty == "StartCap"))
            {
                StartCap = ((PathCaps)(aValue));
                return;
            }
            if ((aProperty == "EndCap"))
            {
                EndCap = ((PathCaps)(aValue));
                return;
            }
            if ((aProperty == "LineWidth"))
            {
                LineWidth = System.Convert.ToSingle(aValue);
                return;
            }
            base.setProp(aProperty, aValue);
        }
        
        public override Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            if ((aProperty == "DisplayName"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(DisplayName);
            }
            if ((aProperty == "PreviewImage"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(PreviewImage);
            }
            if ((aProperty == "Vertices"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Vertices);
            }
            if ((aProperty == "Transform"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Transform);
            }
            if ((aProperty == "Color"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Color);
            }
            if ((aProperty == "Text"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Text);
            }
            if ((aProperty == "ExternalId"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ExternalId);
            }
            if ((aProperty == "ZIndex"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ZIndex);
            }
            if ((aProperty == "Size"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Size);
            }
            if ((aProperty == "ShortId"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ShortId);
            }
            if ((aProperty == "Visibility"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Visibility);
            }
            if ((aProperty == "Selectability"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Selectability);
            }
            if ((aProperty == "ShowDisplayName"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ShowDisplayName);
            }
            if ((aProperty == "DisplayNameColor"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(DisplayNameColor);
            }
            if ((aProperty == "DisplayNameSize"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(DisplayNameSize);
            }
            if ((aProperty == "DropShadow"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(DropShadow);
            }
            if ((aProperty == "OutlineColor"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(OutlineColor);
            }
            if ((aProperty == "OutlineSize"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(OutlineSize);
            }
            if ((aProperty == "OutlineStyle"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(OutlineStyle);
            }
            if ((aProperty == "StartCap"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(StartCap);
            }
            if ((aProperty == "EndCap"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(EndCap);
            }
            if ((aProperty == "LineWidth"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(LineWidth);
            }
            return base.getProp(aProperty);
        }
        #endregion
    }
}
