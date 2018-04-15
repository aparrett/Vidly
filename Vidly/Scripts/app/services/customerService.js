var CustomerService = function () {
    var deleteCustomer = function(customerId, done, fail) {
        $.ajax({
                url: "/api/customers/" + customerId,
                method: "DELETE"
            })
            .done(done)
            .fail(fail);
    }

    return {
        deleteCustomer: deleteCustomer
    }
}();