
var UserLoginViewModel = function () {
    var self = this;
    self.EmailId = ko.observable().extend({ required: { message: "Enter Your Email" } });
    self.PassWord = ko.observable().extend({ required: { message: "Enter Your Password" } });
    self.FirstName = ko.observable();
    self.LastName = ko.observable();
    self.UserName = ko.observable();
    //self.IsRemember = ko.observable(false);
    self.ErrorMessage = ko.observable();

    //self.EnableCheckbox = function (data, event) {
    //    self.IsRemember(event.target.checked);
    //    return true;
    //};
    self.SignIn = function () {
        self.HideFooter();
        self.ErrorMessage('');
        if (self.ValidateInput()) {
            var loginModel = {
                FirstName: self.FirstName(),
                LastName: self.LastName(),
                UserName: self.UserName(),
                EmailId: self.EmailId(),
                Password: self.PassWord()
                //,RememberMe: self.IsRemember()
            }
            var redirectUrl = window.location.origin + 'AuthorizationService\UserSignIn';
            //$.ajax({
            //    type: "POST",
            //    url: redirectUrl,
            //    data: loginModel,
            //    dataType: 'JSON',
            //    success: function (data) {
            //        console.log(data);
            //    }
            //});
            
        }
    };
    self.ValidateInput = function () {
        var isValid = false;
        if (self.EmailId()) {
            isValid = self.ValidateEmail(self.EmailId());
            if (isValid) {
                var fullName = self.EmailId().substring(0, self.EmailId().indexOf("@"));
                var splitName = fullName.split("_");
                self.FirstName(splitName[0]);
                self.LastName(splitName[1]);
                self.UserName(fullName.replace("_", " "));

            } else {
                self.ErrorMessage(self.ErrorMessage() + "<li>Email Should be in Following Format: FirstName_LastName@gmail.com (For Example: John_Smith@gmail.com , William_Roger88@yahoo.com) </li>");
            }
        }
        if (self.errors().length > 0) {
            self.errors.showAllMessages();
            $.each(self.errors(), function (index, value) {
                self.ErrorMessage(self.ErrorMessage() + '<li>' + value + '</li>');
            });
        }
        if (self.ErrorMessage().length > 0) self.ShowFooter(self.ErrorMessage());
        //return self.FirstName() && self.LastName() && self.UserName() && isValid && self.errors().length === 0;
        return isValid && self.errors().length === 0;
    };
    self.ValidateEmail = function (emailId) {
        var pattern = new RegExp("[a-zA-Z]+_+[a-zA-Z0-9]+@+[a-z]+.+[a-z]{2,4}$");
        return pattern.test(emailId);
    };
    self.ShowFooter = function (message) {
        $("#message").html(message);
        $("#message").css("color", "white");
        $(".validationMessage").html('');
        $("#statusMessage").show();
        $("#statusMessage").css("background-color", "crimson"); //palegreen
        $("#statusMessage").delay(7000).fadeOut(2000);
    };
    self.HideFooter = function () {
        $("#message").html('');
        $(".validationMessage").html('');
        $("#statusMessage").hide();

    };
    // init validations
    self.errors = ko.validation.group(self);
};
