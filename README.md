# PID Controller Tech Demo

[Kóðann má finna hérna](Assets/Scripts/PIDController.cs)

PID stjórnandi (e. PID Controller) er tæki til þess að stýra mældu gildi að markgildi.
T.d. Væri hægt að nota þá til þess að stýra hitastigi í ísskáp.
Þar er hitamælir sem gefur mæligildi og markgildi væntanlega stillt um 4°C.
Flygildi nota þessa tækni líka mikið þar sem þarf að stýra afstöðu þeirra með því að breyta afli fjögurra mótora.

Þessi tækni tilheyrir í rauninni ekki reiknilíkönum í tölvunarfræði,
heldur er þetta fall í stærðfræði.

![](https://wikimedia.org/api/rest_v1/media/math/render/svg/2ee061415fdfd20a6676bb328326795fec984cf1 "PID Formula")

PID stendur fyrir Proportional Integral Derivative sem eru fastarnir sem ráða hvernig fallið hagar sér.
Það er einnig hægt að setja einhverja þeirra í núll til þess að búa til PD, PI eða ID stjóra.

**Proportional** fastinn einfaldlega bætir við leiðréttingu í beinu hlutfalli við frávik mæligildisins og markgildisins.
Ef hann vinnur einn þá sveiflast mæligildið yfirleitt í kringum markgildið.

![](https://upload.wikimedia.org/wikipedia/commons/a/a3/PID_varyingP.jpg "PID Formula")

**Integral** fastinn bætir við meiri krafti því lengur og því meira sem mæligildið er í burtu frá markgildinu.
Án hans getur verið að P krafturinn sé ekki nægur til að yfirvinna kraft sem skekkir mæligildið.
T.d. ef flygildi er flogið í miklum vindi eða ef ísskápur er skilinn eftir opinn.

![](https://upload.wikimedia.org/wikipedia/commons/c/c0/Change_with_Ki.png "PID Formula")

**Derivative** fastinn stillir hina kraftana af þegar mæligildið nálgast markgildið þannig að það fari ekki fram hjá heldur stoppi á markgildinu.

![](https://upload.wikimedia.org/wikipedia/commons/c/c7/Change_with_Kd.png "PID Formula")

(Formúla og gröf af [Wikipedia](https://en.wikipedia.org/wiki/PID_controller "Wikipedia síða um PID controllers"))