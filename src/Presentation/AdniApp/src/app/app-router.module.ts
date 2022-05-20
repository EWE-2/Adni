import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { AdniloadingComponent } from "./adniloading/adniloading.component";
import { AdnipageComponent } from "./adnipage/adnipage.component";



const routes: Routes = [
    {path: '', redirectTo: '/Loading', pathMatch: 'full'},
    {path: 'Loading', component: AdniloadingComponent, pathMatch: 'full'},
    {path: 'Adni', component: AdnipageComponent, pathMatch: 'full'},
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule{

}