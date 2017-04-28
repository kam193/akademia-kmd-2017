using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Input;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platform.IoC;
using UIKit;

namespace Piller.iOS.Linker
{
    // LinkerPleaseInclude is never actually executed, but when Xamarin linking is enabled it ensures types and properties are preserved in the deployed app
    // Included are some examples of types and properties you may need preserved in a linked version of your app
    [Preserve(AllMembers = true)]
    public class LinkerPleaseInclude
    {
        public void Include(UIButton uiButton)
        {
            uiButton.TouchUpInside += (s, e) =>
                uiButton.SetTitle(uiButton.Title(UIControlState.Normal), UIControlState.Normal);
        }

        public void Include(UIBarButtonItem barButton)
        {
            barButton.Clicked += (s, e) =>
                barButton.Title = $"{barButton.Title}";
        }

        public void Include(UITextField textField)
        {
            textField.Text = $"{textField.Text}";
            textField.EditingChanged += (sender, args) => { textField.Text = ""; };
        }

        public void Include(UITextView textView)
        {
            textView.Text = $"{textView.Text}";
            textView.Changed += (sender, args) => { textView.Text = ""; };
        }

        public void Include(UILabel label)
        {
            label.Text = $"{label.Text}";
        }

        public void Include(UIImageView imageView)
        {
            imageView.Image = new UIImage(imageView.Image.CGImage);
        }

        public void Include(UIDatePicker date)
        {
            date.Date = date.Date.AddSeconds(1);
            date.ValueChanged += (sender, args) => { date.Date = NSDate.Now; };
        }

        public void Include(UISlider slider)
        {
            slider.Value = slider.Value + 1;
            slider.ValueChanged += (sender, args) => { slider.Value = 1; };
        }

        public void Include(UISwitch sw)
        {
            sw.On = !sw.On;
            sw.ValueChanged += (sender, args) => { sw.On = false; };
        }

        public void Include(INotifyCollectionChanged changed)
        {
            changed.CollectionChanged += (s, e) => { var test = $"{e.Action}{e.NewItems}{e.NewStartingIndex}{e.OldItems}{e.OldStartingIndex}"; };
        }

        public void Include(ICommand command)
        {
            command.CanExecuteChanged += (s, e) => { if (command.CanExecute(null)) command.Execute(null); };
        }

        public void Include(MvxPropertyInjector injector)
        {
            injector = new MvxPropertyInjector();
        }

        public void Include(INotifyPropertyChanged changed)
        {
            changed.PropertyChanged += (sender, e) =>
            {
                var test = e.PropertyName;
            };
        }

        public void Include(MvxTaskBasedBindingContext context)
        {
            context = new MvxTaskBasedBindingContext();
        }
    }
}
