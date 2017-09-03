(function () {
    "use strict";

    angular
        .module("productManagement")
        .controller("ProductListCtrl", ProductListCtrl);

    function ProductListCtrl() {
        var vm = this;

        vm.products = [
            {
                "productId": 1,
                "productName": "Leaft Rake",
                "productCode": "GDN-0011",
                "ReleaseDate": "March 19, 2009",
                "description": "lorem ipsum dolor sit amet consectetur adipiscing elit",
                "price": 19.95
            },
            {
                "productId": 2,
                "productName": "Leaft Rake",
                "productCode": "GDN-0011",
                "ReleaseDate": "March 19, 2009",
                "description": "lorem ipsum dolor sit amet consectetur adipiscing elit",
                "price": 19.95
            },
            {
                "productId": 3,
                "productName": "Leaft Rake",
                "productCode": "GDN-0011",
                "ReleaseDate": "March 19, 2009",
                "description": "lorem ipsum dolor sit amet consectetur adipiscing elit",
                "price": 19.95
            },
            {
                "productId": 4,
                "productName": "Leaft Rake",
                "productCode": "GDN-0011",
                "ReleaseDate": "March 19, 2009",
                "description": "lorem ipsum dolor sit amet consectetur adipiscing elit",
                "price": 19.95
            },
            {
                "productId": 5,
                "productName": "Leaft Rake",
                "productCode": "GDN-0011",
                "ReleaseDate": "March 19, 2009",
                "description": "lorem ipsum dolor sit amet consectetur adipiscing elit",
                "price": 19.95
            },
        ]
    }
}());