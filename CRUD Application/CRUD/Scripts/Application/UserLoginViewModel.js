var UserLoginViewModel = function () {
    var self = this;
    self.EmailId = ko.observable().extend({
        required: {  message: "Email is Required" },
            pattern: {
                message: "Email Should be in Following Format Ex: John_Smith@gmail.com or William_Roger88@yahoo.com",
                //Email Id pattern="[a-zA-Z]+_+[a-zA-Z0-9]+@+[a-z]+.+[a-z]{2,4}$"
                params: "[a-zA-Z]+_+[a-zA-Z0-9]+@+[a-z]+.+[a-z]{2,4}$",
                maxLength: 50
        }
    });
    self.PassWord = ko.observable().extend({
        required: { message: "Password is Required" },
        pattern: {
            maxLength: 50
        }
    });
    self.FirstName = ko.observable();
    self.LastName = ko.observable();
    self.UserName = ko.observable();
    self.IsRemember = ko.observable(false);
    
    self.EnableCheckbox = function (data, event) {
        self.IsRemember(event.target.checked);
        return true;
    };
    self.SignIn = function () {
        if (self.errors().length === 0) {
            var loginModel = {
                EmailId: self.EmailId(),
                Password: self.PassWord(),
                UserName: self.UserName(),
                RememberMe: self.IsRemember()
            }
            var redirectUrl = window.location.origin + 'AuthorizationService\UserSignIn';
            $.ajax({
                type: "POST",
                url: redirectUrl,
                data: loginModel,
                success: self.LoginSuccess(data),
                dataType: 'JSON'
            });
        } else {
            self.errors.showAllMessages();
            var ErrorMessage = '';
            $.each(self.errors(), function (index, value) {
                ErrorMessage = ErrorMessage + '<li>' + value + '</li>';
            });
            $("#message").html(ErrorMessage);
            $("#message").css("color","white")
            $("#statusMessage").show();
            $("#statusMessage").css("background-color", "crimson"); //palegreen
        }
    };
    self.LoginSuccess = function (response) {
        if (response) {
            console.log(response);
        }
    };
    // init validations
    self.errors = ko.validation.group(self);
};