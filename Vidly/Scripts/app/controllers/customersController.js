var CustomersController = function (customerService) {

    var button;

    var init = function (container) {
        $(container).on("click", ".js-delete", deleteCustomer);
    }

    var deleteCustomer = function (e) {
        button = $(e.target);

        var customerId = button.attr("data-customer-id");

        bootbox.confirm("Are you sure you want to delete this customer", function () {
            CustomerService.deleteCustomer(customerId, done, fail);
        });

    };

    var done = function () {
        button.closest("tr").remove();
    };

    var fail = function () {
        alert("Something went wrong");
    };

    return {
        init: init
    }
}(CustomerService);