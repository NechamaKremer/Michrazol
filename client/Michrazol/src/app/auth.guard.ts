import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';

import { Injectable } from '@angular/core';
import { AuthService } from '../app/shared/services/auth.service';
import { Router } from '@angular/router';


@Injectable()
export class AuthGuard implements CanActivate {

    constructor(private authService: AuthService, private router: Router){ }

   canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
        if(this.authService.isAuth()) {
            return true;
         } else {
            this.router.navigate(["/"]);
            return false;
         }
    }
}