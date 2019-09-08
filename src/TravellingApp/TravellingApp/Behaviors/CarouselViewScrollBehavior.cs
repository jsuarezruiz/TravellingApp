using System;
using Xamarin.Forms;

namespace TravellingApp.Behaviors
{
    public class CarouselViewScrollBehavior : Behavior<CarouselView>
    {
        public static readonly BindableProperty ScrollXProperty =
            BindableProperty.Create(nameof(ScrollX), typeof(double), typeof(CarouselViewScrollBehavior), default(double),
                BindingMode.TwoWay, null);

        /// <summary>
        /// The horizontal scroll value in pixels.
        /// </summary>
        public double ScrollX
        {
            get { return (double)GetValue(ScrollXProperty); }
            set { SetValue(ScrollXProperty, value); }
        }

        public static readonly BindableProperty ScrollYProperty =
            BindableProperty.Create(nameof(ScrollY), typeof(double), typeof(CarouselViewScrollBehavior), default(double),
                BindingMode.TwoWay, null);

        /// <summary>
        /// The vertical scroll value in pixels.
        /// </summary>
        public double ScrollY
        {
            get { return (double)GetValue(ScrollYProperty); }
            set { SetValue(ScrollYProperty, value); }
        }

        protected override void OnAttachedTo(CarouselView bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.Scrolled += new EventHandler<ItemsViewScrolledEventArgs>(OnScrolled);
        }

        protected override void OnDetachingFrom(CarouselView bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.Scrolled -= new EventHandler<ItemsViewScrolledEventArgs>(OnScrolled);
        }

        private void OnScrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            ScrollY = e.VerticalOffset;
            ScrollX = e.HorizontalOffset;
        }
    }
}