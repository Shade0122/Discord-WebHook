<h3 align="center">C# Discord WebHook</h3>
<p align="center">
  An easy and reliable way to send an output from a program to a discord webhook in C#.
  <p align="center">
    <a href="https://github.com/Shade0122/Discord-WebHook/issues">Report A Bug</a>
  </p>
</p>

## Setting Up A WebHook
Open discord and make a new channel and adding a webhook and copying its url.
<img src="https://cdn.discordapp.com/attachments/798546575395258379/853016696373248040/v9yp9Y13.gif"/>

## Example
Download the source if you havnt already and insert the url where I place it.
<img src="https://cdn.discordapp.com/attachments/764410688957186058/853017308050096138/v9yp9Y13.gif"/>

Now edit the following strings, `username`, `avatar_url` and `content` to whatever you want.
```CS
Post("https://discord.com/api/webhooks/853010749555212288/ULMATOQitHoSHMJM_Jaw5TsTWSPSi3KvqveESVW4VIKfL9v2BTB-EVYo5vnWzUuXubNI" /*Example of a webhook url.*/, new NameValueCollection()
{
  {"username","Username of the webhook."},
  {"avatar_url","Image that will be used for the webhooks profile picture."},
  {"content","Message to be sent to the webhook and posted by the webhook."},
});
```

And the end result should look something like this.
<img src="https://cdn.discordapp.com/attachments/836367577847431208/853012373861695532/v9yp9Y13.gif"/>

## Contact
If you want to contact me, or report any issues with it you can either do the following:
* [Contact Me On Discord: Shade#0122](https://discord.com)
* [Report Issues](https://github.com/Shade0122/Discord-WebHook/issues)

## Insight
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]

[contributors-shield]: https://img.shields.io/github/contributors/Shade0122/Discord-WebHook.svg?style=for-the-badge
[contributors-url]: https://github.com/Shade0122/Discord-WebHook/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/Shade0122/Discord-WebHook.svg?style=for-the-badge
[forks-url]: https://github.com/Shade0122/Discord-WebHook/network/members
[stars-shield]: https://img.shields.io/github/stars/Shade0122/Discord-WebHook.svg?style=for-the-badge
[stars-url]: https://github.com/Shade0122/Discord-WebHook/stargazers
[issues-shield]: https://img.shields.io/github/issues/Shade0122/Discord-WebHook.svg?style=for-the-badge
[issues-url]: https://github.com/Shade0122/Discord-WebHook/issues
