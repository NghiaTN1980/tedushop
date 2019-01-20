(function (app) {
    app.controller('productAddController', productAddController);

    productAddController.$inject = ['apiService', '$scope', 'notificationService', '$state', 'commonService'];

    function productAddController(apiService, $scope, notificationService, $state, commonService) {
        $scope.product = {
            CreatedDate: new Date(),
            Status: true
        }

        $scope.ckeditorOptions = {
            language: 'vi',
            height: '200px'
        };
        $scope.AddProduct = AddProduct;
        $scope.GetSeoTitle = GetSeoTitle;

        function GetSeoTitle() {
            $scope.product.Alias = commonService.getSeoTitle($scope.productCategory.Name);
        }

        function AddProduct() {
            apiService.post('API/Product/Create', $scope.product,
                function (result) {
                    notificationService.displaySuccess(result.data.Name + ' đã được thêm mới.');
                    $state.go('products');
                }, function (error) {
                    notificationService.displayError('Thêm mới không thành công.');
                });
        }

        function loadProductCategory() {
            apiService.get('API/ProductCategory/GetAllParents', null, function (result) {
                $scope.productCategories = result.data;
            }, function () {
                console.log('Cannot get list parent.');
            });
        }

        loadProductCategory();
    }
})(angular.module('tedushop.products')); 