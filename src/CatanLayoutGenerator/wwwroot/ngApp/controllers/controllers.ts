namespace CatanLayoutGenerator.Controllers {

    export class HomeController {
        public message = 'Hello from the home page!';
    }

    export class SecretController {
        public secrets;

        constructor($http: ng.IHttpService) {
            $http.get('/api/secrets').then((results) => {
                this.secrets = results.data;
            });
        }
    }

    export class PlayerProfileController { }

    export class BoardLayoutController {
        public boardLayouts;

        constructor($http: ng.IHttpService) {
            $http.get('/api/BoardLayouts').then(response => {
                this.boardLayouts = response.data;
            }).catch(response => {
                alert('Something has gone wrong in the BoardLayoutController');
            });
        }
    }

    export class AboutController {
        public message = 'Hello from the about page!';
    }

}
