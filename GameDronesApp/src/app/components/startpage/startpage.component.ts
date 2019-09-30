import { Component, OnInit } from '@angular/core';
import { Validators, FormBuilder } from "@angular/forms";
import { Router } from "@angular/router";

@Component({
  selector: 'app-startpage',
  templateUrl: './startpage.component.html',
  styleUrls: ['./startpage.component.scss']
})
export class StartpageComponent implements OnInit {

  loginForm: any;

  constructor(private formBuilder: FormBuilder,
    private router: Router) {
    this.buildForm();
  }

  ngOnInit() { }

  onSubmit() {
    console.log(this.loginForm.value);
    this.router.navigate(['contest']);
  }

  buildForm() {
    this.loginForm = this.formBuilder.group({
      username1: ['', Validators.required],
      username2: ['', Validators.required]
    })
  }

}
