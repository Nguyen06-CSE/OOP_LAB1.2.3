using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int soMenu = 30;
            int chon;
            List<int> ds = new List<int>();
            NhapNgauNhien(ds, 10);

            do
            {
                XuatMenu();
                chon = ChonMenu(soMenu);
                XuLyMenu(chon, ref n, ds);
            } while (chon != 0);


        }


        static void XuatMenu()
        {
            Console.WriteLine("____________________MENU_____________________");
            Console.WriteLine("0.\tthoat khoi chuong trinh ");
            Console.WriteLine("1.\tĐảo ngược thứ tự các phần tử trong mảng.\r\n2.\tXoá tất cả các phần tử trùng nhau, giữ lại phần tử đầu tiên.\r\n3.\tTạo một mảng mới với các số chia hết cho 3.\r\n4.\tTính tổng lớn nhất của một dãy con liên tiếp.\r\n5.\tTìm số lượng các số liên tiếp có tổng bằng S.\r\n6.\tKiểm tra xem có tồn tại ba phần tử liên tiếp có tổng bằng x.\r\n7.\tĐếm số lần xuất hiện của từng phần tử trong mảng.\r\n8.\tTìm tất cả các dãy con có tổng bằng một số nguyên tố.\r\n9.\tTìm dãy con có độ dài lớn nhất chứa toàn số chẵn.\r\n10.\tTìm độ dài dãy tăng dài nhất.\r\n11.\tTìm dãy giảm dài nhất.\r\n12.\tĐếm số lần giá trị x xuất hiện liên tiếp trong mảng.\r\n13.\tTìm vị trí xuất hiện cuối cùng của một giá trị trong mảng.\r\n14.\tKiểm tra xem mảng có đối xứng không.\r\n15.\tNhân mỗi phần tử của mảng với số k.\r\n16.\tTìm giá trị gần nhất với x.\r\n17.\tĐếm số lượng cặp phần tử có tổng lớn hơn y.\r\n18.\tTạo một mảng mới là tổng của hai mảng cùng kích thước.\r\n19.\tTìm phần tử có khoảng cách lớn nhất với x.\r\n20.\tTách mảng thành các dãy con liên tiếp tăng dần.\r\n21.\tTìm dãy con có tổng nhỏ nhất.\r\n22.\tTìm tổng của các phần tử chia hết cho cả 3 và 5.\r\n23.\tXoá tất cả các số nhỏ hơn 0.\r\n24.\tTạo một mảng chứa các bình phương của các phần tử trong mảng ban đầu.\r\n25.\tTính tổng các phần tử có giá trị lớn hơn giá trị trung bình.\r\n26.\tTính khoảng cách lớn nhất giữa hai số 0 trong mảng.\r\n27.\tTìm phần tử lớn nhất ở vị trí lẻ.\r\n28.\tTìm phần tử nhỏ nhất ở vị trí chẵn.\r\n29.\tĐếm số lượng phần tử liên tiếp có giá trị bằng nhau.\r\n30.\tTạo mảng chứa tất cả các ước của các phần tử trong mảng ban đầu.\r\n");
        }

        static int ChonMenu(int soMenu)
        {
            int chon;

            do
            {
                Console.Write($"Nhập chọn [0....{soMenu}]: ");
                chon = int.Parse(Console.ReadLine());
                if (chon >= 0 && chon <= soMenu)
                {
                    break;
                }
            } while (true);
            return chon;
        }

        static void XuLyMenu(int chon, ref int n, List<int> ds)
        {
            int x;
            switch (chon)
            {
                case 0:
                    Console.WriteLine("Thoát khỏi chương trình");
                    break;
                case 1:
                    
                    Xuat(DaoNguoc(ds));
                    break;
                case 2:
                    Xuat(XoaCacPTTrungNhau(ds));
                    break;
                case 3:
                    Xuat(MangChiaHetCho3(ds));
                    break;
                case 4:
                    Console.WriteLine("Tong lon nhat cua mot day con lien tiep la: " + TongLonNhatDayCon(ds));
                    break;
                case 5:
                    Console.Write("Nhap gia tri tong ban muon so sanh: ");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("so luong cac so lien tiep co tong bang " + x + " trong mang la: " + DemDayConCoTongBangS(ds, x));
                    break;
                case 6:
                    Console.Write("Nhap gia tri tong ban muon so sanh: ");
                    x = int.Parse(Console.ReadLine());
                    CoBaPhanTuLienTiepTongX(ds, x);
                    break;
                case 7:
                    XuatCap(DemSoLanXuatHien(ds));
                    break;
                case 8:

                    if (TimDayConCoTongNguyenTo(ds).Count != 0)
                    {
                        Xuat(TimDayConCoTongNguyenTo(ds));
                    }
                    else TimDayConCoTongNguyenTo(ds);
                    break;
                case 9:
                    Xuat(DayConToanChanDaiNhat(ds));
                    break;
                case 10:
                    Console.WriteLine("do dai day tang dai nhat la: " + DoDaiDayTangDaiNhat(ds));

                    break;
                case 11:
                    Console.WriteLine("do dai day giam dai nhat la: " + DoDaiDayGiamDaiNhat(ds));

                    break;
                case 12:
                    Console.Write("Nhap gia tri ban muon dem: ");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("so lan gia tri " + x + " xuat hien trong mang la: " + DemSoLanXuatHien(ds));

                    
                    break;
                case 13:
                    Console.Write("Nhap gia tri ban tim kiem vi tri cuoi cung trong mang: ");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("vi tri xuat hien cuoi cung cua gia tri " + x + " trong mang la: " + TimViTriCuoiCung(ds, x));
                    break;
                case 14:
                    if (LaMangDoiXung(ds)) Console.WriteLine("mang la mang doi xung nha!!!");
                    else Console.WriteLine("mang ko phai la mang doi xung nha!!!");

                    break;
                case 15:
                    Console.Write("Nhap gia tri ban muon nhan voi moi phan tu trong mang: ");
                    x = int.Parse(Console.ReadLine());
                    Xuat(NhanMangVoiK(ds, x));
                    break;
                case 16:
                    Console.Write("Nhap gia tri x ban muon : ");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("gia tri gan voi " +  x + " trong mang la: " + TimGiaTriGanNhat(ds,x)); 



                    break;
                case 17:
                    Console.Write("Nhap gia tri tong ban muon : ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("so luong cap phan tu co gia tri lon hon " + x + " la: " + DemCapPhanTuTongLonHonY(ds,x));

                    break;

                case 18:
                    List<int> ds1 = new List<int>();
                    List<int> ds2 = new List<int>();
                    Console.WriteLine("nhap mang dau tien di");
                    Nhap(ds1);
                    Console.WriteLine("nhap mang thu hai di");
                    Nhap(ds2);
                    Console.WriteLine("mang sau khi tinh tong hai mang la");
                    Xuat(TongHaiMang(ds1, ds2));

                    break;
                case 19:
                    Console.Write("Nhap gia tri de tim khoang cach ban muon : ");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Phan tu co khoang cach lon nhat voi " + x + " la phan tu" + TimPhanTuKhoangCachLonNhat(ds,x));

                    break;
                case 20:
                    XuatMangHaiChieu(TachMangThanhDayConTangDan(ds));
                    
                    break;
                case 21:
                    Xuat(TimDayConCoTongNhoNhat(ds));
                    
                    
                    break;
                case 22:
                    Console.WriteLine("tong phan tu chia het cho 3 va 5 trong mang la: " + TongPhanTuChiaHetCho3Va5(ds));
                    break;
                case 23:
                    Xuat(XoaSoNhoHon0(ds));

                    break;
                case 24:
                    Xuat(BinhPhuongMang(ds));
                    
                    
                    break;
                case 25:
                    Console.WriteLine("tong cac phan tu co gia tri lon hon trung binh la: " + TongLonHonTrungBinh(ds));                
                    
                    
                    break;
                case 26:
                    if (KhoangCachLonNhatGiuaHaiSo0(ds) != -1) Console.WriteLine("khoang cach lon nhat giua hai so 0 la: " + KhoangCachLonNhatGiuaHaiSo0(ds));
                    else Console.WriteLine("mang ko co hai so 0");
                    
                    
                    
                    
                    break;
                case 27:
                    Console.WriteLine("phan tu lon nhat o vi tri le la: " + PhanTuLonNhatViTriLe(ds));
                    break;
                case 28:

                    Console.WriteLine("phan tu nho nhat o vi tri chan la: " + PhanTuNhoNhatViTriChan(ds));

                    break;
                case 29:
                    Console.WriteLine("so luong phan tu lien tiep co gia tri bang nhau la: " + DemSoLuongPhanTuLienTiepBangNhau(ds));
                    break;


                case 30:
                    Xuat(TimTatCaUocSo(ds));
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }

        static void Nhap(List<int> ds)
        {
            Console.WriteLine("nhap so phan tu");
            var dem = int.Parse(Console.ReadLine());
            for (int i = 0; i < dem; i++)
            {
                Console.Write("nhap vao phan tu thu {0}: ", i); // Sử dụng Console.Write thay vì Console.WriteLine
                ds.Add(int.Parse(Console.ReadLine()));
            }
        }

        static void NhapNgauNhien(List<int> ds, int k)
        {

            Random random = new Random();
            for (int i = 0; i < k; i++)
            {
                ds.Add(random.Next(10));
            }
        }

        static void Xuat(List<int> ds)
        {
            foreach (int i in ds)
            {
                Console.Write($"{i}" + '\t');
            }
            Console.WriteLine();
        }

        static void XuatMangHaiChieu(List<List<int>> ds)
        {
            foreach (var subSequence in ds)
            {
                Console.WriteLine(string.Join(", ", subSequence));
            }
            Console.WriteLine();
        }


        static void XuatCap(List<(int, int)> result)
        {
            foreach (var pair in result)
            {
                Console.WriteLine($"({pair.Item1}, {pair.Item2})");
            }
            Console.WriteLine();
        }


        static List<int> DaoNguoc(List<int> ds)
        {
            List<int> list = new List<int>();
            for(int i = ds.Count - 1; i >= 0; i--)
            {
                list.Add(ds[i]);
            }

            return list;
        }

        static List<int> XoaCacPTTrungNhau(List<int> ds)
        {
            List<int> res = new List<int>();
            for(int i = 0 ; i < ds.Count ; i++)
            {
                if(!res.Contains(ds[i])) res.Add(ds[i]);
            }
            return res;
        }


        static List<int> MangChiaHetCho3(List<int> ds)
        {
            List<int> res = new List<int>();
            foreach (int num in ds)
            {
                if (num % 3 == 0) res.Add(num);
            }
            return res;
        }

        static int TongLonNhatDayCon(List<int> ds)
        {
            int maxSum = ds[0], currentSum = ds[0];
            for (int i = 1; i < ds.Count; i++)
            {
                currentSum = Math.Max(ds[i], currentSum + ds[i]);
                maxSum = Math.Max(maxSum, currentSum);
            }
            return maxSum;
        }


        static int DemDayConCoTongBangS(List<int> ds, int S)
        {
            int count = 0;
            for (int i = 0; i < ds.Count; i++)
            {
                int sum = 0;
                for (int j = i; j < ds.Count; j++)
                {
                    sum += ds[j];
                    if (sum == S) count++;
                }
            }
            return count;
        }

        static bool CoBaPhanTuLienTiepTongX(List<int> ds, int x)
        {
            for (int i = 0; i < ds.Count - 2; i++)
            {
                if (ds[i] + ds[i + 1] + ds[i + 2] == x) return true;
            }
            return false;
        }





        static List<(int, int)> DemSoLanXuatHien(List<int> ds)
        {
            List<(int, int)> result = new List<(int, int)>();
            List<int> uniqueNumbers = XoaCacPTTrungNhau(ds);

            foreach (int num in uniqueNumbers)
            {
                int dem = 0;
                foreach (int i in ds)
                {
                    if (i == num)
                    {
                        dem++;
                    }
                }
                result.Add((num, dem));
            }

            return result;
        }

        

        static bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static List<int> TimDayConCoTongNguyenTo(List<int> ds)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < ds.Count; i++)
            {
                int sum = 0;
                for (int j = i; j < ds.Count; j++)
                {
                    sum += ds[j];
                    if (LaSoNguyenTo(sum)) result.Add(sum);
                }
            }
            return result;
        }


        static void UpdateMaxSub(List<int> currentSub, ref List<int> maxSub)
        {
            if (currentSub.Count > maxSub.Count)
            {
                maxSub = new List<int>(currentSub); 
            }
        }

        static List<int> DayConToanChanDaiNhat(List<int> ds)
        {
            List<int> maxSub = new List<int>(), currentSub = new List<int>();
            foreach (int num in ds)
            {
                if (num % 2 == 0) currentSub.Add(num);  
                else currentSub.Clear();  

                UpdateMaxSub(currentSub, ref maxSub); 
            }
            return maxSub;
        }

        static int FindMax(int a, int b)
        {
            return a > b ? a : b;
        }

        static int DoDaiDayTangDaiNhat(List<int> ds)
        {
            if (ds.Count == 0) return 0;  

            int maxLen = 1, currentLen = 1;
            for (int i = 1; i < ds.Count; i++)
            {
                if (ds[i] > ds[i - 1])  
                {
                    currentLen++;  
                }
                else
                {
                    currentLen = 1;  
                }

                maxLen = FindMax(currentLen, maxLen);  
            }
            return maxLen;
        }

        

        static int DoDaiDayGiamDaiNhat(List<int> ds)
        {
            int maxLen = 1, currentLen = 1;
            for (int i = 1; i < ds.Count; i++)
            {
                if (ds[i] < ds[i - 1]) currentLen++;
                else currentLen = 1;

                maxLen = FindMax(currentLen, maxLen);
            }
            return maxLen;
        }

        static int DemSoLanXuatHienLienTiep(List<int> ds, int x)
        {
            int maxCount = 0, currentCount = 0;
            foreach (int num in ds)
            {
                if (num == x) currentCount++;
                else currentCount = 0;

                maxCount = FindMax(currentCount, maxCount);
            }
            return maxCount;
        }

        static int TimViTriCuoiCung(List<int> ds, int x)
        {
            for (int i = ds.Count - 1; i >= 0; i--)
            {
                if (ds[i] == x) return i;
            }
            return -1;
        }

        static bool LaMangDoiXung(List<int> ds)
        {
            for (int i = 0; i < ds.Count / 2; i++)
            {
                if (ds[i] != ds[ds.Count - 1 - i]) return false;
            }
            return true;
        }

        static List<int> NhanMangVoiK(List<int> ds, int k)
        {
            List<int> res = new List<int>();
            foreach (int num in ds) res.Add(num * k);
            return res;
        }

        static int TimGiaTriGanNhat(List<int> ds, int x)
        {
            int closest = ds[0], minDiff = Math.Abs(ds[0] - x);
            foreach (int num in ds)
            {
                int diff = Math.Abs(num - x);
                if (diff < minDiff)
                {
                    minDiff = diff;
                    closest = num;
                }
            }
            return closest;
        }

        static int DemCapPhanTuTongLonHonY(List<int> ds, int y)
        {
            int count = 0;
            for (int i = 0; i < ds.Count; i++)
            {
                for (int j = i + 1; j < ds.Count; j++)
                {
                    if (ds[i] + ds[j] > y) count++;
                }
            }
            return count;
        }

        static List<int> TongHaiMang(List<int> ds1, List<int> ds2)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < ds1.Count; i++)
            {
                res.Add(ds1[i] + ds2[i]);
            }
            return res;
        }

        static int TimPhanTuKhoangCachLonNhat(List<int> ds, int x)
        {
            int maxDist = 0, result = ds[0];
            foreach (int num in ds)
            {
                int dist = Math.Abs(num - x);
                if (dist > maxDist)
                {
                    maxDist = dist;
                    result = num;
                }
            }
            return result;
        }

        static List<List<int>> TachMangThanhDayConTangDan(List<int> ds)
        {
            List<List<int>> result = new List<List<int>>();
            List<int> subArray = new List<int>();

            for (int i = 0; i < ds.Count; i++)
            {
                if (subArray.Count == 0 || ds[i] > subArray.Last())
                {
                    subArray.Add(ds[i]);
                }
                else
                {
                    result.Add(new List<int>(subArray));
                    subArray.Clear();
                    subArray.Add(ds[i]);
                }
            }

            if (subArray.Count > 0) result.Add(subArray);
            return result;
        }

        static List<int> TimDayConCoTongNhoNhat(List<int> ds)
        {
            List<int> minSubArray = new List<int>();
            int minSum = int.MaxValue;

            for (int i = 0; i < ds.Count; i++)
            {
                int sum = 0;
                List<int> tempSubArray = new List<int>();

                for (int j = i; j < ds.Count; j++)
                {
                    sum += ds[j];
                    tempSubArray.Add(ds[j]);

                    if (sum < minSum)
                    {
                        minSum = sum;
                        minSubArray = new List<int>(tempSubArray);
                    }
                }
            }
            return minSubArray;
        }

        static int TongPhanTuChiaHetCho3Va5(List<int> ds)
        {
            int sum = 0;
            foreach (int num in ds)
            {
                if (num % 3 == 0 && num % 5 == 0) sum += num;
            }
            return sum;
        }

        static List<int> XoaSoNhoHon0(List<int> ds)
        {
            List<int> res = new List<int>();
            foreach (int num in ds)
            {
                if (num >= 0) res.Add(num);
            }
            return res;
        }

        static List<int> BinhPhuongMang(List<int> ds)
        {
            List<int> res = new List<int>();
            foreach (int num in ds) res.Add(num * num);
            return res;
        }



        static int TongLonHonTrungBinh(List<int> ds)
        {
            int sumResult = 0;
            int sum = ds.Sum();
            double avg = (double)sum / ds.Count;
            foreach(int num in ds)
            {
                if(num > avg) sumResult += num;
            }
            return sumResult;
        }

        static int KhoangCachLonNhatGiuaHaiSo0(List<int> ds)
        {
            int first = -1, last = -1;
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i] == 0)
                {
                    if (first == -1) first = i;
                    last = i;
                }
            }
            return (first != -1 && last != -1) ? last - first : 0;
        }


        static int PhanTuLonNhatViTriLe(List<int> ds)
        {
            int max = int.MinValue;
            for (int i = 1; i < ds.Count; i += 2)
            {
                if (ds[i] > max) max = ds[i];
            }
            return max;
        }

        static int PhanTuNhoNhatViTriChan(List<int> ds)
        {
            int min = int.MaxValue;
            for (int i = 0; i < ds.Count; i += 2)
            {
                if (ds[i] < min) min = ds[i];
            }
            return min;
        }

        static int DemSoLuongPhanTuLienTiepBangNhau(List<int> ds)
        {
            if (ds.Count == 0) return 0;

            int maxCount = 1, currentCount = 1;
            for (int i = 1; i < ds.Count; i++)
            {
                if (ds[i] == ds[i - 1]) currentCount++;
                else currentCount = 1;

                
                maxCount = FindMax(currentCount, maxCount);
            }
            return maxCount;
        }

        static List<int> TimTatCaUocSo(List<int> ds)
        {
           
            List<int> factors = new List<int>(XoaCacPTTrungNhau(ds));
            foreach (int num in ds)
            {
                for (int i = 1; i <= Math.Abs(num); i++)
                {
                    if (num % i == 0) factors.Add(i);
                }
            }
            return factors.ToList();
        }





    }
}
