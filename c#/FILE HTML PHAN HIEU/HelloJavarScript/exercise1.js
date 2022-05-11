// cho một object 
// cho biết tên hoặc mã số và cho biết thuộc tính cần tìm

class ThongTinSinhVien{
    constructor(hoTen , tuoi , queQuan){
        this.hoTen = hoTen;
        this.tuoi = tuoi;
        this.queQuan = queQuan;
    }
}
var phanDucHieu= new ThongTinSinhVien("hieu", 19 , "tuyen quang");
var nguyenThuyTrang = new ThongTinSinhVien("trang", 17 , "nghe an");
var dinhVanTung = new ThongTinSinhVien("tung" , 22 , "tuyen quang");

function hieu(name){
    document.getElementById("demo").innerHTML= ThongTinSinhVien.queQuan;
    console.log(name);

    }
hieu("phanDucHieu");
