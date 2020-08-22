var UserLoginViewModel = function () {
    var self = this;
    self.EmailId = ko.observable();
    self.PassWord = ko.observable();
    self.FirstName = ko.observable();
    self.LastName = ko.observable();
    self.IsRemember = ko.observable(false);
    self.UserName = ko.computed(function () {
        //if (self.FirstName() && self.LastName()) {
            //return self.FirstName() + " " + self.LastName();
        //}

    }, self);
    self.EnableCheckbox = function (data, event) {
        self.IsRemember(event.target.checked);
        return true;
    };
    self.SignIn = function (data, event) {
        if (self.EmailId() && self.PassWord()) {
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
        }
    };
    self.LoginSuccess = function (response) {
        if (response) {
            console.log(response);
        }
    };
};