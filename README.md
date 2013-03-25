Softbuild.Social.Line
=====================

## 概要

griffin_stewieさんが作成された「CSLINEOpener」をXamarin.iOS向けに移植しました。

NHN Japan株式会社が提供しているiOS向けLINEアプリへ「LINEで送るボタン」機能を提供します。ご利用には [ガイドライン](http://media.line.naver.jp/guideline/ja/ "ガイドライン｜LINEで送るボタン") に従う必要があります。

LINEアプリに対して文字列もしくは画像を送る `LineOpener` クラスがあります。

## 使い方

### LineOpener

テキストを送る場合

```
if (LineOpener.CanOpenLine()) {
    LineOpener.OpenLine("I love you.");
} else {
    LineOpener.OpenAppStore();
}
```

画像を送る場合

```
var image = new UIImage("sample.png");
if (LineOpener.CanOpenLine()) {
    LineOpener.OpenLine(image);
} else {
    LineOpener.OpenAppStore();
}
```

## インストール

Softbuild.Social.Line プロジェクトをソリューションに追加し、プロジェクト参照してください。

## ライセンス

MIT License

Created by Kenji Wada on 2013/03/26.

Original project created by griffin_stewie on 2013/02/01.

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
