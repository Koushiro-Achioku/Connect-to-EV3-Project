#自己紹介#

改めまして、高校生プログラマーのKoushiroです。WROは2015年から参加し始め、2017・2018年にJapan大会に進出、FLLは2015-2016シーズンは予選落ち、2016-2017シーズンはJapan大会進出を果たしました。RCX?NXT?EV3と使用し、Mindstorms歴5年目となります。2017年のWROレギュレーションから高校生に限り、EV3標準ソフトウェア以外の開発環境も使えることになり、EV3rtを使用し始めました。よってEV3rt使用歴は2年です。2018年のWROをもって現役は退き、現在は後輩の指導を行っています。その一環としてQiitaで[後輩たちのためのEV3rt講座](https://qiita.com/koushiro/items/4d18c877c93f823fc236)を連載しております。

#WROが終わってからの研究#

9月にWROが終了し、プロジェクトに一区切りがつきました。私には、大学受験の勉強が本格的に始まる前にどうしても作っておきたいものがありました。
EV3標準ソフトウェアには、PCとインテリジェントブロックと接続した時に、センサーの値を監視できる機能があります。
(画像挿入)
これ、あると何かと便利なんです。例えば、ライントレースに使用する黒線の値を測ったり、モーターの回転角を測ったり、言い出せばキリがないですが、なにせ便利なんです。
でも、EV3rtでセンサー値を見るには、ファイルに書き出したり、あるいは狭?いLCDに書き込んだりしないといけません。僕も`fprintf`でtxtファイルに値を書き込み、Excelでロギングしていました。
ただ正直言って、面倒で使いづらいですよね。ということで、EV3rtでBluetooth経由でのセンサー値監視アプリを作ろうと決心したのであります。

#作成したソフトがこちら!!#
(画像挿入)
名前は**"Connect to EV3"**です。(いや、そのまんまかよ…)
主な機能は以下の通り

- リモートスタート
- モーターの各種値受信・表示
- センサーの各種値受信・表示

冒頭説明したとおり、私は高校生でまだまだ未熟な者ですので、はっきり言ってプログラムに非効率な部分があるかと思います。
よって、実際のコードについては本記事内では触れません。
ただ、このプログラムの使い方やプロセスに関しては話しておきたいと思います。

#プログラムファイルの配布#
今回作成したファイルを、ソースコード含め配布したいと思います。
DropboxのリンクとGithubのリンクと2つ用意しています。
Githubに関しては使い始めてまだ2カ月ほどで、ほとんど使い方がわかりませんが、一応用意しておきました。
どちらか使いやすいほうを選んでいただけたらと思います。

[Dropboxのリンク]()
[Githubのリンク]()

#プログラムの流れ#
詳しい内容に関しては、配布zip同梱のReferenceというPDFを参照してください。
ここではおおまかな流れのみ説明します。

##1.Bluetooth接続##
EV3とPCをBluetoothで接続します。
今回の通信は仮想シリアルポートを使用します。
それにあたり、通常の接続方法とは少し違うので、Referenceをよく確認してください。

##2.Windows側のアプリを実行##
`"Connect_to_EV3.exe"`を実行します。
実行したらCOMポート開通させて、EV3とBluetooth通信を開始します。

##3.EV3側のアプリを実行します##
EV3側にappを転送します。
コンパイル済みのアプリが配布zip内にありますのでそれを転送してください。
次に転送したアプリを実行すると、`"Please Connect"`と出てきます。
これが出たらEV3は一度待機です。

##4.通信プログラムを開始##
再びPC側に戻り、`"Start"`ボタンを押します。
上手くセッティングできていれば、コンソール画面に値が流れ出します。

##5.センサー・モーターをConfig##
この段階では、センサーやモーターはConfigされておらず、値は常に0を返します。
これをPC側から選択し、正しい値を返すようにします。
(ここで正しいセンサー・モーターを選択しないと、フリーズしてしまいます。)

##完成!!##
ここまで完璧にできれば、角ポートごとにリアルタイムの値が表示されます。
ラグもあまりないので実用性はあると思っています!!

#通信の仕組み#
今回の通信では先ほども述べたように、Bluetooth経由の仮想シリアルポートを使っています。
通信は双方とも送受信可能で、以下のような通信を行います。

- PC->EV3 リモートスタート
- PC->EV3 センサー・モーターのConfig
- EV3->PC センサー・モーター値を返す

全ての通信がASCIIコードでの文字列送信により行われています。

リモートスタートは

```Form1.cs
serialPort1.Write("1");
```

センサー・モーターのConfigは

```Form1.cs
/*配列の宣言*/
public char[] port1 = new char[4] { '1', '0', '0', '0' };
/*port1[0]:ポート,port1[1]:センサー種類,port1[2]:取得モード,port1[3]:未指定*/

/*値の送信*/
string s = new string(port1);
if (serialPort1.IsOpen == true) { serialPort1.Write(s); }
```

センサー・モーターの値を返す時は

```app.c
static FILE     *bt = NULL;
bt = ev3_serial_open_file(EV3_SERIAL_BT);

fprintf(bt,"1%d,%d,%d#2%d,%d,%d#3%d,%d,%d#4%d,%d,%d#5%d#6%d#7%d#8%d#\r\n",
        data[0][0],data[1][0],data[2][0],data[0][1],data[1][1],data[2][1],data[0][2],data[1][2],data[2][2],data[0][3],data[1][3],data[2][3],
        data[0][4],data[0][5],data[0][6],data[0][7]);
```

というような具合です。
(一部抜粋、順序無関係なので、実際のプログラムとは異なります。実際の流れはソースコードを見てご自分でご確認ください。)

#プログラムの応用#
ここからはかなり高度かつ、自己責任的要素が伴いますのでご了承ください。

##任意のプログラムに組み込む##
このプログラムは最初の接続が終わると、周期ハンドラが起動し、3つの関数が超高速周期で動きます。

