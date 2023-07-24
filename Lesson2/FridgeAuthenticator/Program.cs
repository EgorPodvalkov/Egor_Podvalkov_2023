using FridgeAuthenticator;
using FridgeAuthenticator.Services;

var fridge = new Dictionary<string, string>();
var registrator = new FridgeRegistrator(fridge);
var app = new AuthenticatorMenu(registrator);

app.StartApp();
