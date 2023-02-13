
<center>

    ** DỰ ÁN PHÁT TRIỂN GAME 2D **
    
# Fighting Kala War
</center>


<center>

### **GIỚI THIỆU GAME**
    
</center>

#### Sơ lượt về game

Fighing Kala War là một game thuộc thể loại đối kháng đơn giản được tạo ra bằng công cụ Unity2D, người chơi sẽ hóa thân thành một nhân vật để chiến đấu với một nhân vật còn lại với các cấp độ dễ, trung bình và khó.

<center>
    
![](https://i.imgur.com/uSIx8Uh.png)
    
</center>


[![Demo Video](https://www.youtube.com/watch?v=AlAILQoI2pM&t=15s/0.jpg)](https://www.youtube.com/watch?v=AlAILQoI2pM&t=15s)



##### Cốt truyện

Bên ngoài vũ trụ xa xôi, Có một hành tinh tên là Kala tồn tại 4 chủng tộc và mỗi chủng tộc ẩn chứa trong mình nhiều sức mạnh phi thường khác nhau. Họ thường có mối quan hệ không được tốt đẹp và hay xảy ra các trận chiến xung đột với nhau. Một ngày nọ, họ được ban quản lý vũ trụ mời tham gia vào “Kala War”, đây là nơi để đại diện mạnh nhất của từng chủng tộc thi đấu với nhau và tìm ra được người mạnh nhất chiến thắng giải đấu này. Người thắng cuộc sẽ mang về vinh quang là chủng tộc mạnh nhất cho chủng tộc của mình trong vòng 2 năm tới, cùng với đó là phần thưởng cho người thắng cuộc là các phần thưởng vô cùng giá trị.

#### Nhân vật trong game
●	Chiến binh tộc Kim 

<center>
    
![](https://i.imgur.com/V8F0No8.png)

    
</center>


●	Chiến binh tộc Mộc
 

<center>
    
![](https://i.imgur.com/wOebeyv.png)


</center>

●	Chiến binh tộc Thủy
 

<center>
    
![](https://i.imgur.com/fVp8rMm.png)


</center>


●	Chiến binh tộc Hỏa
 

<center>
    
![](https://i.imgur.com/2QAWRjL.png)


</center>


<center>

### **THIẾT KẾ**
    
</center>

#### Thiết kế cảnh chơi và menu, Nhân vật

•	Scene Menu:  Là màn hình sẽ hiển thị khi người dùng vào game. Màn hình sẽ có nút button là “Quit” để thoát game và “Play” sẽ chuyển đến sceen optionMenu.

<center>
    
![](https://i.imgur.com/8dzJjB9.png)


</center>


•	OptionMenu: Là màn hình để người chơi lựa chọn nhân vật, lựa chọn Enemy và cấp độ của game. Màn hình sẽ có một button lựa chọn cấp độ. Mỗi khi người dùng bấm vào sẽ thay đổi cấp độ người dùng muốn, bao gồm 3 lựa chọn Easy (Dễ), Medium ( trung bình), High (khó). Button hình dấu mũi tên bên trái để lựa chọn Player, Button dấu mũi tên bên phải để lựa chọn Enemy. Sau khi người dùng tạo xong thì bấm “Start Game” để game chuyển về Scene main và người dùng bắt đầu chơi. Ngoài ra trong màn hình còn có thêm button back để trở về scene Menu.

<center>
    
![](https://i.imgur.com/PGMmwik.png)

</center>

•	Playgame: Đây là giao diện chơi game, sẽ bao gồm 4 thanh thanh slider là máu và sức mạnh của Player và Enemy. Và 3 nút button như bật tắt nhạc, ngừng hoặc tiếp tục chơi game và nút back game để trở về  màn hình OptionMenu. Độ khó, player và enemy được người chơi chọn sẽ được xuất hiện ở đây.


<center>
    
![](https://i.imgur.com/RvL8bvW.png)


</center>


•	Nhân vật: Nhân vật được sử dụng trong game được thiết kế bằng cách vẽ ra từng bộ phân và dùng khung xương (Một framwork của Unity) để kế nối chúng lại.


<center>
    
![](https://i.imgur.com/d8qNboI.png)

    
![](https://i.imgur.com/nO4iwGX.png)
    
    
![](https://i.imgur.com/7JLisTO.png)


</center>

•	ShootPlayer là các loại đạn tương ứng với 3 chiêu thức skill1, skill2, skill3 của nhân vật. tất cả các shootPlayer đều được thêm hộp va chạm, vật lí xuyên qua.


<center>
    
![](https://i.imgur.com/DeIVnBA.png)


</center>



* Design cấu trúc cây hành vi: Để tạo ra một cây hành vi, trong project sử dụng một Framwork miễn phí tên là TheTikiCoder. Công cụ này sẽ hỗ trợ chúng ta tạo ra một cây trạng thái một cách dễ dàng.


![](https://i.imgur.com/c2MQ2d7.png)








<center>

### **CÁCH CHƠI**
    
    
</center>

#### Phím bấm di chuyển và các chiêu thức

![](https://i.imgur.com/mngDKwM.png)



![](https://i.imgur.com/pg25s0d.png)





