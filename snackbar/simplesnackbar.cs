
var view = FindViewById<View>(Resource.Id.layoutparent);

//verbose one
Snackbar snackbar;
snackbar = Snackbar.Make(view, "Text to fill", Snackbar.LengthLong);
snackbar.Show();

//simple one
Snackbar.Make(view, "text to fill", Snackbar.LengthLong).Show();
