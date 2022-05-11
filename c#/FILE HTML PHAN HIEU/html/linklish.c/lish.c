#include<stdio.h>
#include<stdlib.h>

struct soNguyen{
int dulieu;
struct soNguyen *next;
}*node;
void taoDanhSach(nodepdau){
    int repeat;
    soNguyen *p=pdau;
    do{
        if(pdau==NULL){
            pdau=(soNguyen*)malloc(sizeof(soNguyen));
            p=pdau;
        }else
        {
            p=pdau;
            while(p->next!=NULL) p=p->next;
            p->next=(soNguyen*)malloc(sizeof(soNguyen));
            p=p->next
        }
        printf("ban co muon nhap  nua khong");
        scanf("%d",&(p->dulieu));
        p->next=NULL;
        printf("ban co muon tiep tuc khong");
        scanf("%d",&repeat);
    }while(repeat!=0); 
}
void printList(soNguyen *&pdau){
    soNguyen *p= pdau;
    if(pdau==NULL) return;
    while(p!=NULL){
        printf("%d",p->dulieu);
        p=p->next;
    }

}
    int main(){
soNguyen->*pdau = NULL;
taoDanhSach( pdau);
printList(pdau);

    return 0;
}