# Sandpit.vNext

## Installing ASP.NET vNext

First you'll need to install the KVM and KRE:

https://github.com/aspnet/Home/wiki/version-manager

## Running the samples

### Console

* Navigate to example folder
* Run ```kpm restore```
* Type ```k run```

### Web

* Navigate to example folder
* Run ```kpm restore```
* Type ```k web```
* Open a browser and type http://localhost:5001

NB Currently the MVC examples only work with KRE 0446 and so you must execute ```kvm install 0.1-alpha-build-0446``` to switch before running ```kpm restore``` and ```k web```