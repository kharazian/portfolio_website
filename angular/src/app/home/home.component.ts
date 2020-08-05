import { Component, OnInit } from '@angular/core';
import { Meta, Title } from '@angular/platform-browser';
import { GithubService } from './../services/github.service';

import { AREAS } from './areas';

@Component({
	selector: 'app-home',
	templateUrl: './home.component.html',
	styleUrls: ['./home.component.scss']
})


export class HomeComponent implements OnInit {
  title = 'Home';
  areas = AREAS;
	profile: any;
	repos: number;
  lastUpdated: string;
  mainImg: string;
  
	constructor(
    private githubService: GithubService,
    private metaTagService: Meta,
    private titleService: Title
  ) { }

	getRepoData(): void {
		this.githubService.getUserProfile()
			.subscribe(resultArray => {
				this.profile = resultArray;
				this.repos = this.profile.public_repos;
        this.lastUpdated = this.profile.updated_at;
        this.mainImg = this.profile.avatar_url;
        
			});
	}

	ngOnInit(): void {
    this.getRepoData();
    this.titleService.setTitle(this.title);
    this.metaTagService.updateTag(
      {
        name: 'home',
        content: 'andrewbateman.org'
      });
  }

}
