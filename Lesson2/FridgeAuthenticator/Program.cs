using FridgeAuthenticator;
using FridgeAuthenticator.Services;

var fridge = new Fridge();
var registrator = new FridgeRegistrator(fridge);
var app = new AuthenticatorMenu(registrator);

app.StartApp();
