# SWDV280_SWDV_App
App to keep those interested in CWI Software Development program informed.

Notes for next Team:
- A NuGet package was added to provide funtionality for the Form Views of the PWPortal page. We found that a new instance needed to be installed each 
 iteration. The Syncfusion.Xamarin.SfPdfViewer is the NuGet package used.
 
- If images don't display we found that we needed to check the build actions in the properties section of the files. 
  - For pdf's in Assets folder, set to "embedded resource".
  - For jpg's in Images folder set to "content".

- Included a CWI icon folder that can be implemented as well to replace standard "X" that Xamarin provides.
