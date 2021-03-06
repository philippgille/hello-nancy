[![Build status](https://ci.appveyor.com/api/projects/status/sjbx6mxag11hsilu?svg=true)](https://ci.appveyor.com/project/philippgille/hello-nancy)
[![Build Status](https://travis-ci.org/philippgille/hello-nancy.svg)](https://travis-ci.org/philippgille/hello-nancy)
[![Coverity Scan Build Status](https://scan.coverity.com/projects/4413/badge.svg)](https://scan.coverity.com/projects/4413)
[![Coverage Status](https://coveralls.io/repos/philippgille/hello-nancy/badge.svg)](https://coveralls.io/r/philippgille/hello-nancy)
[![Stories in Ready](https://badge.waffle.io/philippgille/hello-nancy.png?label=ready&title=Ready)](https://waffle.io/philippgille/hello-nancy)

Hello Nancy
========

This repository contains a minimal [Nancy](http://nancyfx.org/) project with [ASP.NET](http://www.asp.net/) hosting, created with [Visual Studio Community 2013](http://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx).

It runs on [AppHarbor](https://appharbor.com/) and [Microsoft Azure Website](http://azure.microsoft.com/en-us/services/websites/), which are PaaS providers like [Heroku](https://www.heroku.com/) or [Amazon Web Services Elastic Beanstalk](http://aws.amazon.com/de/elasticbeanstalk/):

- [http://hellonancy.apphb.com](http://hellonancy.apphb.com)
- [http://hellonancy.azurewebsites.net](http://hellonancy.azurewebsites.net)

Both are configured to fetch the code from GitHub.

TODO
----

- Deploy on Heroku (using [this](https://github.com/friism/heroku-buildpack-mono) buildpack)
- Deploy on AWS
